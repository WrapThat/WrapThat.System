using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;
using NUnit.Framework;
using WrapThat.SystemIO;
using LibUsingFileFunctions.Wrapped;
using WrapThat.SystemBase;

namespace TestThatLib
{
    public class TestIt
    {
        [Test]
        public void ThatCheckFilesWorks()
        {
            // Common setup
            var file = Substitute.For<IFile>();
            var directory = Substitute.For<IDirectory>();
            var systemio = Substitute.For<ISystemIO>();
            systemio.File.Returns(file);
            systemio.Directory.Returns(directory);

            var underTest = new FileHandling(systemio);

            // Assume
            var testdir = "someNiceDirectory";
            directory.GetCurrentDirectory().Returns(testdir);
            directory.GetFiles(Arg.Is(testdir), Arg.Any<string>(), Arg.Is(SearchOption.AllDirectories)).Returns(new[] { "a", "b" });

            // Act
            var resultA = underTest.CheckFilesInSomeDirectory(testdir).ToList();

            // Assert
            Assert.That(resultA.Count, Is.EqualTo(2), "Count failed");
            Assert.That(resultA[0], Is.EqualTo("a"), "First entry failed");



        }


        [Test]
        public void ThatReadingLinesWorks()
        {
            // Common setup
            var file = Substitute.For<IFile>();
            var directory = Substitute.For<IDirectory>();
            var systemio = Substitute.For<ISystemIO>();
            systemio.File.Returns(file);
            systemio.Directory.Returns(directory);

            var underTest = new FileHandling(systemio);

            // Assume
            var testdir = "someNiceDirectory";
            file.Exists(Arg.Is(testdir)).Returns(true);

            var expectedText = "The answer is 42";
            file.ReadAllText(testdir).Returns(expectedText);

            // Act
            var txt = underTest.ReadAllLinesFromAFile(testdir);

            // Assert
            Assert.That(txt,Is.EqualTo(expectedText));

            
        }

        [Test]
        public void ThatFileExistMethodWorks()
        {
            // Assume 
            var file = Substitute.For<IFile>();
            file.Exists(Arg.Any<string>()).Returns(true);
            var systemio = Substitute.For<ISystemIO>();
            systemio.File.Returns(file);

            var  underTest = new FileHandling(systemio);

            // Act
            var result = underTest.FileExist("whatever");

            // Assert
            Assert.That(result);

        }


        [Test]
        public void TestWrite()
        {
            var console = Substitute.For<IConsole>();
            
            var underTest = new ConcoleBasedLib(console);

            underTest.WeWrite();

            console.Received().WriteLine(Arg.Any<string>());
            
        }


        [Test]
        public void TestRead()
        {
            var console = Substitute.For<IConsole>();
            console.ReadLine().Returns("Cool stuff");

            var underTest = new ConcoleBasedLib(console);

            underTest.WeRead();

            console.Received().WriteLine("Cool stuff indeed!");

        }



    }
}
