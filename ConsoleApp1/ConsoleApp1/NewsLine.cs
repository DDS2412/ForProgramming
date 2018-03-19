using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeTestLoginovIP
{
    class NewsLine : IEnumerable
    {
        private List<Record> records;

        private bool IsContained(Record record)
        {
            return records.Contains(record);
        }

        public NewsLine()
        {
            records = new List<Record>();
        }

        public void AddLine(Record newRecord)
        {
            records.Add(newRecord);
        }

        public bool RemoveRecords(Record deletedRecord)
        {
            if (IsContained(deletedRecord))
            {
                return records.Remove(deletedRecord);
            }

            return false;
        }

        public Record[] SearchRecord(int ID)
        {
            return records.FindAll(n => n.ID == ID).ToArray();
        }

        public void SortRecords()
        {
            bool IsSorted;
            do
            {
                IsSorted = true;
                for (int i = 0; i < records.Count - 1; i++)
                {
                    if (records[i].ID > records[i + 1].ID)
                    {
                        IsSorted = false;
                        Record tmp = records[i];
                        records[i] = records[i + 1];
                        records[i + 1] = tmp;
                    }
                }
            } while (!IsSorted);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public RecordEnum GetEnumerator()
        {
            return new RecordEnum(records.ToArray());
        }
    }
}

