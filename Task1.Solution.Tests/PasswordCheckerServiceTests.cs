using System;
using Moq;
using NUnit.Framework;
using Task1.Solution.Repositories;
using Task1.Solution.PasswordValidators;

namespace Task1.Solution.Tests
{
    [TestFixture]
    class PasswordCheckerServiceTests
    {
        [Test]
        public void Ctor_NullRepositoryPassed_ArgumentNullExceptionThrown()
        {
            Assert.Throws<ArgumentNullException>(() => new PasswordCheckerService(null));
        }

        [Test]
        public void ValidatePassword_NullPasswordValidatorPassed_ArgumentNullExceptionThrown()
        {
            var repositoryMock = Mock.Of<IRepository>();

            Assert.Throws<ArgumentNullException>(() =>
                new PasswordCheckerService(repositoryMock).ValidatePassword("", null));
        }

        [Test]
        public void ValidatePassword_ValidPasswordPassed_RepositoryCreateCalled()
        {
            var password = "test";
            var repositoryMock = new Mock<IRepository>();
            var passwordValidator = new Mock<IPasswordValidator>();
            repositoryMock.Setup(repository => repository.Create(It.Is<string>(s => s == password)));
            passwordValidator.Setup(validator => validator.Validate(It.IsAny<string>()))
                .Returns(Tuple.Create(true, ""));

            var service = new PasswordCheckerService(repositoryMock.Object);
            service.ValidatePassword(password, passwordValidator.Object);

            repositoryMock.Verify();
        }

        [Test]
        public void ValidatePassword_InvalidPasswordPassed_RepositoryCreateIsNotCalled()
        {
            var password = "test";
            var repositoryMock = new Mock<IRepository>();
            var passwordValidator = new Mock<IPasswordValidator>();
            repositoryMock.Setup(repository => repository.Create(It.IsAny<string>()));
            passwordValidator.Setup(validator => validator.Validate(It.IsAny<string>()))
                .Returns(Tuple.Create(false, ""));

            var service = new PasswordCheckerService(repositoryMock.Object);
            service.ValidatePassword(password, passwordValidator.Object);

            repositoryMock.Verify(repository => repository.Create(It.IsAny<string>()), Times.Never());
        }
    }
}
