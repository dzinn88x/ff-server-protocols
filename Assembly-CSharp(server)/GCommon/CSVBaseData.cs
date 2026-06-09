using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000F1F RID: 3871
	[Token(Token = "0x2000F1F")]
	public abstract class CSVBaseData
	{
		// Token: 0x06003700 RID: 14080
		[Token(Token = "0x6003700")]
		public abstract void ParseData(long index, int fieldCount, string[] headers, string[] values);

		// Token: 0x06003701 RID: 14081
		[Token(Token = "0x6003701")]
		public abstract string GetPrimaryKey();

		// Token: 0x06003702 RID: 14082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003702")]
		public T As<T>() where T : CSVBaseData
		{
			return null;
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x06003703 RID: 14083 RVA: 0x00010EC0 File Offset: 0x0000F0C0
		[Token(Token = "0x170006BF")]
		public virtual bool UsingIndexedParseData
		{
			[Token(Token = "0x6003703")]
			[Address(RVA = "0x25E6E30", Offset = "0x25E6E30", VA = "0x7BBCDE6E30", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003704 RID: 14084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003704")]
		[Address(RVA = "0x25E6E38", Offset = "0x25E6E38", VA = "0x7BBCDE6E38", Slot = "7")]
		public virtual string[] GetHeadColNames()
		{
			return null;
		}

		// Token: 0x06003705 RID: 14085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003705")]
		[Address(RVA = "0x25E6E40", Offset = "0x25E6E40", VA = "0x7BBCDE6E40", Slot = "8")]
		public virtual void ParseData(IIndexString ss, int[] index)
		{
		}

		// Token: 0x06003706 RID: 14086 RVA: 0x00010ED8 File Offset: 0x0000F0D8
		[Token(Token = "0x6003706")]
		[Address(RVA = "0x25D8810", Offset = "0x25D8810", VA = "0x7BBCDD8810")]
		protected static float ReadFloat(string fieldName, string[] headers, string[] values, float defaultValue = 0f)
		{
			return 0f;
		}

		// Token: 0x06003707 RID: 14087 RVA: 0x00010EF0 File Offset: 0x0000F0F0
		[Token(Token = "0x6003707")]
		[Address(RVA = "0x25D928C", Offset = "0x25D928C", VA = "0x7BBCDD928C")]
		protected static int ReadInt(string fieldName, string[] headers, string[] values, int defaultValue = 0)
		{
			return 0;
		}

		// Token: 0x06003708 RID: 14088 RVA: 0x00010F08 File Offset: 0x0000F108
		[Token(Token = "0x6003708")]
		[Address(RVA = "0x25E6F54", Offset = "0x25E6F54", VA = "0x7BBCDE6F54")]
		protected static int ReadInt(string value, int defaultValue = 0)
		{
			return 0;
		}

		// Token: 0x06003709 RID: 14089 RVA: 0x00010F20 File Offset: 0x0000F120
		[Token(Token = "0x6003709")]
		[Address(RVA = "0x25E6F5C", Offset = "0x25E6F5C", VA = "0x7BBCDE6F5C")]
		protected static uint ReadUInt(string fieldName, string[] headers, string[] values, uint defaultValue = 0U)
		{
			return 0U;
		}

		// Token: 0x0600370A RID: 14090 RVA: 0x00010F38 File Offset: 0x0000F138
		[Token(Token = "0x600370A")]
		[Address(RVA = "0x25E6FF4", Offset = "0x25E6FF4", VA = "0x7BBCDE6FF4")]
		protected static uint ReadUInt(string value, uint defaultValue)
		{
			return 0U;
		}

		// Token: 0x0600370B RID: 14091 RVA: 0x00010F50 File Offset: 0x0000F150
		[Token(Token = "0x600370B")]
		[Address(RVA = "0x25E6FFC", Offset = "0x25E6FFC", VA = "0x7BBCDE6FFC")]
		protected static uint ReadUInt(string value)
		{
			return 0U;
		}

		// Token: 0x0600370C RID: 14092 RVA: 0x00010F68 File Offset: 0x0000F168
		[Token(Token = "0x600370C")]
		[Address(RVA = "0x25E7080", Offset = "0x25E7080", VA = "0x7BBCDE7080")]
		protected static byte ReadByte(string value)
		{
			return 0;
		}

		// Token: 0x0600370D RID: 14093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600370D")]
		[Address(RVA = "0x25E70E8", Offset = "0x25E70E8", VA = "0x7BBCDE70E8")]
		public static void ClearCommonStrings()
		{
		}

		// Token: 0x0600370E RID: 14094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600370E")]
		[Address(RVA = "0x25E7174", Offset = "0x25E7174", VA = "0x7BBCDE7174")]
		protected static string ReadCommonString(string value)
		{
			return null;
		}

		// Token: 0x0600370F RID: 14095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600370F")]
		[Address(RVA = "0x25E7270", Offset = "0x25E7270", VA = "0x7BBCDE7270")]
		protected static string ReadCommonString(string fieldName, string[] headers, string[] values, [Optional] string defaultValue)
		{
			return null;
		}

		// Token: 0x06003710 RID: 14096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003710")]
		[Address(RVA = "0x25D86C4", Offset = "0x25D86C4", VA = "0x7BBCDD86C4")]
		protected static string ReadString(string fieldName, string[] headers, string[] values, [Optional] string defaultValue)
		{
			return null;
		}

		// Token: 0x06003711 RID: 14097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003711")]
		[Address(RVA = "0x25E7300", Offset = "0x25E7300", VA = "0x7BBCDE7300")]
		protected static string[] ReadStringArray(string fieldName, string[] headers, string[] values, [Optional] string defaultValue)
		{
			return null;
		}

		// Token: 0x06003712 RID: 14098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003712")]
		[Address(RVA = "0x25E73F8", Offset = "0x25E73F8", VA = "0x7BBCDE73F8")]
		protected static uint[] ReadUIntArray(string fieldName, string[] headers, string[] values, uint defaultValue = 0U, char InSplitChar = ',')
		{
			return null;
		}

		// Token: 0x06003713 RID: 14099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003713")]
		[Address(RVA = "0x25E7594", Offset = "0x25E7594", VA = "0x7BBCDE7594")]
		protected static int[] ReadIntArray(string fieldName, string[] headers, string[] values, int defaultValue = 0, char InSplitChar = ',')
		{
			return null;
		}

		// Token: 0x06003714 RID: 14100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003714")]
		[Address(RVA = "0x25E7794", Offset = "0x25E7794", VA = "0x7BBCDE7794")]
		protected static float[] ReadFloatArray(string fieldName, string[] headers, string[] values, char InSplitChar = '#')
		{
			return null;
		}

		// Token: 0x06003715 RID: 14101 RVA: 0x00010F80 File Offset: 0x0000F180
		[Token(Token = "0x6003715")]
		[Address(RVA = "0x25D88A8", Offset = "0x25D88A8", VA = "0x7BBCDD88A8")]
		protected static bool ReadBoolean(string fieldName, string[] headers, string[] values, bool defaultValue = false)
		{
			return default(bool);
		}

		// Token: 0x06003716 RID: 14102 RVA: 0x00010F98 File Offset: 0x0000F198
		[Token(Token = "0x6003716")]
		[Address(RVA = "0x25E7938", Offset = "0x25E7938", VA = "0x7BBCDE7938")]
		protected static bool ReadBoolean(string value)
		{
			return default(bool);
		}

		// Token: 0x06003717 RID: 14103 RVA: 0x00010FB0 File Offset: 0x0000F1B0
		[Token(Token = "0x6003717")]
		[Address(RVA = "0x25E7A08", Offset = "0x25E7A08", VA = "0x7BBCDE7A08")]
		protected static ResourceID ReadResourceID(string fieldName, string[] headers, string[] values, Type resVarType)
		{
			return default(ResourceID);
		}

		// Token: 0x06003718 RID: 14104 RVA: 0x00010FC8 File Offset: 0x0000F1C8
		[Token(Token = "0x6003718")]
		[Address(RVA = "0x25E7B30", Offset = "0x25E7B30", VA = "0x7BBCDE7B30")]
		protected static ResourceID ReadResourceID(string strResID, Type resVarType)
		{
			return default(ResourceID);
		}

		// Token: 0x06003719 RID: 14105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003719")]
		[Address(RVA = "0x25E7C14", Offset = "0x25E7C14", VA = "0x7BBCDE7C14")]
		protected static ResourceID[] ReadResourceIDArray(string fieldName, string[] headers, string[] values, Type resVarType)
		{
			return null;
		}

		// Token: 0x0600371A RID: 14106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600371A")]
		[Address(RVA = "0x25E6E44", Offset = "0x25E6E44", VA = "0x7BBCDE6E44")]
		protected static string GetFieldValueWithFieldName(string fieldName, string[] headers, string[] values, [Optional] string defaultValue)
		{
			return null;
		}

		// Token: 0x0600371B RID: 14107 RVA: 0x00010FE0 File Offset: 0x0000F1E0
		[Token(Token = "0x600371B")]
		[Address(RVA = "0x25E7DF4", Offset = "0x25E7DF4", VA = "0x7BBCDE7DF4")]
		public static implicit operator bool(CSVBaseData exists)
		{
			return default(bool);
		}

		// Token: 0x0600371C RID: 14108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600371C")]
		[Address(RVA = "0x25D89C0", Offset = "0x25D89C0", VA = "0x7BBCDD89C0")]
		protected CSVBaseData()
		{
		}

		// Token: 0x040049DA RID: 18906
		[Token(Token = "0x40049DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<string, string> s_CommonStrings;
	}
}
