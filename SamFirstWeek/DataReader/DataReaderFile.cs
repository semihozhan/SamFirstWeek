namespace SamFirstWeek.DataReader
{
    public static class DataReaderFile
    {
        public static List<int> GetT(string path)
        {
           
            List<int> listData= new List<int>();
            using (StreamReader st = new StreamReader(path))
            {
                string line;
                while ((line = st.ReadLine()) != null)
                {
                    try
                    {
                        listData.Add(int.Parse(line));
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }
            }
                return listData;
        }

        public static List<KeyValuePair<int, string>> CreateListReverseAndAddDate(List<int> data)
        {
            List<KeyValuePair<int, string>> ts=new List<KeyValuePair<int, string>>();
            DateTime dt = DateTime.Now;
            for (int i = 0; i < data.Count; i++)
            {
                ts.Add(new KeyValuePair<int, string>(data[i], dt.AddDays((data.Count-i)*-1).ToString() ));
            }
            return ts;
        }

    }
}
