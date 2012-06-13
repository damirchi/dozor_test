using System.ComponentModel;

namespace GFK.Business
{
	public class ItemReportData
	{
		public ItemReportData()
		{
		}

		public ItemReportData(int id, int colimnId, string header, object value)
		{
			Id = id;
			ColumnId = colimnId;
			Header = header;
			Value = value;
		}

		public ItemReportData(int id, int colimnId, string header, object value, string format)
		{
			Id = id;
			ColumnId = colimnId;
			Header = header;
			Value = value;
			Format = format;
		}

		public ItemReportData(int id, int colimnId, string header, object value, string format, string textAlign)
		{
			Id = id;
			ColumnId = colimnId;
			Header = header;
			Value = value;
			Format = format;
			TextAlign = textAlign;
		}

		[Description("Id")]
		public int Id { get; set; }

		[Description("Id")]
		public int ColumnId { get; set; }

		[Description("Header")]
		public string Header { get; set; }

		[Description("Value")]
		public object Value { get; set; }

		[Description("Format")]
		public string Format { get; set; }

		[Description("TextAlign")]
		public string TextAlign { get; set; }

		[Description("FontStyle")]
		public string FontStyle { get; set; }

		[Description("FontSize")]
		public string FontSize { get; set; }
	}
}