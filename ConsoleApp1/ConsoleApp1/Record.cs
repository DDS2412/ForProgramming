using System;
using System.Collections.Generic;

namespace SomeTestLoginovIP
{
    public class Record : IEquatable<Record>
    {
        public string Title { get; set; }
        public int ID { get; }
        public string Text { get; set; }
        public int AuthorId { get; }

        public Record(string title, int iD, string text, int authorId)
        {
            this.Title = title;
            this.ID = iD;
            this.Text = text;
            this.AuthorId = authorId;
        }

        public bool Equals(Record other)
        {
            if (this == null)
            {
                return other == null;
            }

            return other != null && this.ID == other.ID;
        }

        public override int GetHashCode()
        {
            var hashCode = 1892236401;
            hashCode = hashCode * -1521134295 + this.ID.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return String.Format(
                          $"Record id: {ID}\n" +
                          $"Author id: {AuthorId}\n" +
                          $"Title: {Title}\n" +
                          $"Text: {Text}");
        }
    }
}