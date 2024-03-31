using System;
using Xunit;
using UnitTestApplication;

namespace Sample.Test.Unit
{
    public class UnitTest1
    {

        [Fact]
        public void Test1()
        {

            var ProgrammeService = new Program();
            var strinemail = string.Empty;
            var exceptedmessage = "Email is requied";

            var exceptionmessagedetails = Assert.Throws<ArgumentException>(() => ProgrammeService.GetStudentID(strinemail));
            Assert.Equal(exceptedmessage, exceptionmessagedetails.Message);

        }

        [Fact]
        public void Should_PassCorrectObjectStudent()
        {
            var studentservice = new Program();
            var courseid = 100;

            var actualstudent = studentservice.GetStudentByCourseID(courseid);

            Assert.IsType<CSharpStudent>(actualstudent);
        }

        [Fact]
        public void Should_PassOddValue()
        {
            var studentservice = new Program();
            int isoddvalue = 3;
            var actualvalue = studentservice.IsOdd(isoddvalue);

            Assert.True(actualvalue);

        }


        [Theory]
        [InlineData(2,false)]
        [InlineData(12, false)]
        [InlineData(121, true)]
        [InlineData(120, false)]
        public void Check_MultipleOddandEven(int passvalue , bool expectedvalue)
        {

            var studentservice = new Program();
           
            var actualvalue = studentservice.IsOdd(passvalue);

            Assert.Equal(expectedvalue, actualvalue);

        }
    }
}
