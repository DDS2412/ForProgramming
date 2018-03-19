using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SomeTestLoginovIP
{
    class RecordEnum : IEnumerator
    {
        public Record[] _records;
        int position = -1;

        public RecordEnum(Record[] list)
        {
            _records = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _records.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Record Current
        {
            get
            {
                try
                {
                    return _records[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

    }
}
