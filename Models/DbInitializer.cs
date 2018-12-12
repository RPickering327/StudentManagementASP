using System.Linq;

namespace StudentManagement.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Courses.Any())
            {

                context.AddRange
                (

                    new Course { Name = "Mathematics - Pi & SquareRoots", Grade = 60, IsCourseFull = false, ShortDescritpion = "Introduction into Pi and square roots.", LongDescription = "An introduction into PI and square roots and how they can be used in the real world.", NumberOfSpaces = 300, ImageThumbnailUrl = "https://img.purch.com/w/660/aHR0cDovL3d3dy5saXZlc2NpZW5jZS5jb20vaW1hZ2VzL2kvMDAwLzA4MS85MDEvb3JpZ2luYWwvcGktZGF5LmpwZw==", ImageUrl = "https://img.purch.com/w/660/aHR0cDovL3d3dy5saXZlc2NpZW5jZS5jb20vaW1hZ2VzL2kvMDAwLzA4MS85MDEvb3JpZ2luYWwvcGktZGF5LmpwZw==" },
                    new Course { Name = "Human Studies - Year One", Grade = 60, IsCourseFull = false, ShortDescritpion = "Introduction into Human studies.", LongDescription = "An introduction into Human studies ", NumberOfSpaces = 300, ImageThumbnailUrl = "https://img.purch.com/w/660/aHR0cDovL3d3dy5saXZlc2NpZW5jZS5jb20vaW1hZ2VzL2kvMDAwLzA4MS85MDEvb3JpZ2luYWwvcGktZGF5LmpwZw==", ImageUrl = "https://img.purch.com/w/660/aHR0cDovL3d3dy5saXZlc2NpZW5jZS5jb20vaW1hZ2VzL2kvMDAwLzA4MS85MDEvb3JpZ2luYWwvcGktZGF5LmpwZw==" },
                    new Course { Name = "Art and Design - Year One", Grade = 55, IsCourseFull = false, ShortDescritpion = "Introduction into Art and design", LongDescription = "Lessons on how to draw human bodies and the history behind art deco.", NumberOfSpaces = 300, ImageThumbnailUrl = "https://img.purch.com/w/660/aHR0cDovL3d3dy5saXZlc2NpZW5jZS5jb20vaW1hZ2VzL2kvMDAwLzA4MS85MDEvb3JpZ2luYWwvcGktZGF5LmpwZw==", ImageUrl = "https://img.purch.com/w/660/aHR0cDovL3d3dy5saXZlc2NpZW5jZS5jb20vaW1hZ2VzL2kvMDAwLzA4MS85MDEvb3JpZ2luYWwvcGktZGF5LmpwZw==" },
                    new Course { Name = "History - Year One", Grade = 50, IsCourseFull = false, ShortDescritpion = "History between 1700-1900", LongDescription = "An indepth look into history between 1700-1900. Looking at the impact of wars across Europe.", NumberOfSpaces = 300, ImageThumbnailUrl = "https://img.purch.com/w/660/aHR0cDovL3d3dy5saXZlc2NpZW5jZS5jb20vaW1hZ2VzL2kvMDAwLzA4MS85MDEvb3JpZ2luYWwvcGktZGF5LmpwZw==", ImageUrl = "https://img.purch.com/w/660/aHR0cDovL3d3dy5saXZlc2NpZW5jZS5jb20vaW1hZ2VzL2kvMDAwLzA4MS85MDEvb3JpZ2luYWwvcGktZGF5LmpwZw==" },
                    new Course { Name = "History - Year Two", Grade = 50, IsCourseFull = false, ShortDescritpion = "History between 1700-1900", LongDescription = "An indepth look into history between 1700-1900. Looking at the impact of wars across Europe.", NumberOfSpaces = 300, ImageThumbnailUrl = "https://img.purch.com/w/660/aHR0cDovL3d3dy5saXZlc2NpZW5jZS5jb20vaW1hZ2VzL2kvMDAwLzA4MS85MDEvb3JpZ2luYWwvcGktZGF5LmpwZw==", ImageUrl = "https://img.purch.com/w/660/aHR0cDovL3d3dy5saXZlc2NpZW5jZS5jb20vaW1hZ2VzL2kvMDAwLzA4MS85MDEvb3JpZ2luYWwvcGktZGF5LmpwZw==" }
                );

            }

            context.SaveChanges();

        }
    }
}
