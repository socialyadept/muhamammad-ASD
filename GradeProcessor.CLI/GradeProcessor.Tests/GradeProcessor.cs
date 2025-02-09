namespace GradeProcessor.Tests
{
    public class GradeProcessorTests
    {
        [Fact]
        public void CalculateAverage_ShouldReturnCorrectAverage()
        {
            List<int> grades = new List<int> { 80, 90, 100 };
            double result = GradeProcessor.Core.GradeProcessor.CalculateAverage(grades);
            Assert.Equal(90.0, result, 1);
        }

        [Fact]
        public void CalculateAverage_ShouldHandleEmptyList()
        {
            List<int> grades = new List<int> { };
            Assert.Throws<System.ArgumentException>(() => GradeProcessor.Core.GradeProcessor.CalculateAverage(grades));
        }

        [Fact]
        public void CalculateAverage_ShouldHandle100MGradesIn1Sec()
        {
            List<int> grades = Enumerable.Range(1, 100_000_000).ToList();
            DateTime start = DateTime.UtcNow;
            GradeProcessor.Core.GradeProcessor.CalculateAverage(grades);
            DateTime end = DateTime.UtcNow;
            double elapsed = (end - start).TotalMilliseconds;
            Assert.True(elapsed < 200, $"Execution took {elapsed} ms");
        }

        // New Tests written by Krithika Manjunath, although she already paired up with someone else she gave me tests for which I wrote the functional code in the GradeProcessor.Core file since I couldn't find another partner to pair up with.
        [Fact]
        public void CalculateMaximum_ShouldReturnHighestGrade()
        {
            int expected = 100;
            List<int> grades = new List<int> { 80, 95, 70, 100, 85 };
            int result = GradeProcessor.Core.GradeProcessor.CalculateMaximum(grades);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CalculateMaximum_ShouldHandleEmptyList()
        {
            List<int> grades = new List<int>();
            Assert.Throws<ArgumentException>(() => GradeProcessor.Core.GradeProcessor.CalculateMaximum(grades));
        }

        [Fact]
        public void CalculateMaximum_ShouldHandleSingleGrade()
        {
            double expected = 85;
            List<int> grades = new List<int> { 85 };
            int result = GradeProcessor.Core.GradeProcessor.CalculateMaximum(grades);
            Assert.Equal(85, result);
        }

        // Tests for Median Grade
        [Fact]
        public void CalculateMedian_ShouldReturnMedianForOddCount()
        {
            double expected = 90.0;
            List<int> grades = new List<int> { 70, 85, 90, 95, 100 };
            double result = GradeProcessor.Core.GradeProcessor.CalculateMedian(grades);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CalculateMedian_ShouldReturnMedianForEvenCount()
        {
            double expected = 90.0;
            List<int> grades = new List<int> { 70, 85, 95, 100 };
            double result = GradeProcessor.Core.GradeProcessor.CalculateMedian(grades);
            Assert.Equal(expected, result); // Average of 85 and 95
        }

        [Fact]
        public void CalculateMedian_ShouldReturnMedianForLargeVariations()
        {
            double expected = 8;
            List<int> grades = new List<int> { 4, 0, 1, 8, 85, 95, 100 };
            double result = GradeProcessor.Core.GradeProcessor.CalculateMedian(grades);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CalculateMedian_ShouldHandleEmptyList()
        {
            List<int> grades = new List<int>();
            Assert.Throws<ArgumentException>(() => GradeProcessor.Core.GradeProcessor.CalculateMedian(grades));
        }

        [Fact]
        public void CalculateMedian_ShouldHandleSingleGrade()
        {
            double expected = 85;
            List<int> grades = new List<int> { 85 };
            double result = GradeProcessor.Core.GradeProcessor.CalculateMedian(grades);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CalculateMedian_ShouldHandleUnsortedList()
        {
            double expected = 90.0;
            List<int> grades = new List<int> { 100, 70, 95, 85, 90 };
            double result = GradeProcessor.Core.GradeProcessor.CalculateMedian(grades);
            Assert.Equal(90.0, result);
        }
    }
}
