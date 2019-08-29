using System;
using System.Collections.Generic;
using System.Text;

namespace LargeDataLoop
{
    class Record
    {
        public string SAMPLE_NAME { get; set; }
        public string WWTP_CODE { get; set; }
        public string LOCATION { get; set; }
        public int NUMBER { get; set; }
        public string AXYS_ID { get; set; }
        public string COMPOUND { get; set; }
        public string LAB_FLAG { get; set; }
        public double CONCENTRATION_FOUND { get; set; }
        public string DETECTION_LIMIT { get; set; }
        public string UNIT { get; set; }
        public DateTime COLLECTION_DATE { get; set; }
        public string WORKGROUP { get; set; }

    }
}
