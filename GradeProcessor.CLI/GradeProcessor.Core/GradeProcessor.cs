namespace GradeProcessor.Core
{
    public class GradeProcessor
    {
        public static double CalculateAverage(List<int> grade)
        {
            if (grade.Count == 0)
            {
                throw new ArgumentException("Empty List");
            }
            return grade.Average();
        }

        // implementation here
        public static int CalculateMaximum(List<int> grades)
        {
            if (grades.Count == 0)
            {
                throw new ArgumentException("Empty List");
            }
            return grades.Max();
        }

        public static double CalculateMedian(List<int> grades)
        {
            if (grades.Count == 0)
            {
                throw new ArgumentException("Empty List");
            }

            var sortedGrades = grades.OrderBy(g => g).ToList();
            int mid = sortedGrades.Count / 2;

            if (sortedGrades.Count % 2 == 0)
            {
                return (sortedGrades[mid - 1] + sortedGrades[mid]) / 2.0;
            }
            else
            {
                return sortedGrades[mid];
            }
        }
    }


}
