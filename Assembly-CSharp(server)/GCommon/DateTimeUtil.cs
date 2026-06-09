using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000F21 RID: 3873
	[Token(Token = "0x2000F21")]
	public static class DateTimeUtil
	{
		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x06003721 RID: 14113 RVA: 0x00011028 File Offset: 0x0000F228
		[Token(Token = "0x170006C0")]
		public static DateTime UTCStartDateTime
		{
			[Token(Token = "0x6003721")]
			[Address(RVA = "0x25EDEBC", Offset = "0x25EDEBC", VA = "0x7BBCDEDEBC")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x06003722 RID: 14114 RVA: 0x00011040 File Offset: 0x0000F240
		[Token(Token = "0x6003722")]
		[Address(RVA = "0x25EDFF8", Offset = "0x25EDFF8", VA = "0x7BBCDEDFF8")]
		public static ulong GetCurrentLocalTimeStampSeconds()
		{
			return 0UL;
		}

		// Token: 0x06003723 RID: 14115 RVA: 0x00011058 File Offset: 0x0000F258
		[Token(Token = "0x6003723")]
		[Address(RVA = "0x25EE138", Offset = "0x25EE138", VA = "0x7BBCDEE138")]
		public static double GetCurrentLocalTimeStampMilliseconds()
		{
			return 0.0;
		}

		// Token: 0x06003724 RID: 14116 RVA: 0x00011070 File Offset: 0x0000F270
		[Token(Token = "0x6003724")]
		[Address(RVA = "0x25EE26C", Offset = "0x25EE26C", VA = "0x7BBCDEE26C")]
		public static ulong GetCurrentTimeStamp()
		{
			return 0UL;
		}

		// Token: 0x06003725 RID: 14117 RVA: 0x00011088 File Offset: 0x0000F288
		[Token(Token = "0x6003725")]
		[Address(RVA = "0x25EE2DC", Offset = "0x25EE2DC", VA = "0x7BBCDEE2DC")]
		public static DateTime GetCurrentDateTime()
		{
			return default(DateTime);
		}

		// Token: 0x06003726 RID: 14118 RVA: 0x000110A0 File Offset: 0x0000F2A0
		[Token(Token = "0x6003726")]
		[Address(RVA = "0x25EE35C", Offset = "0x25EE35C", VA = "0x7BBCDEE35C")]
		public static DateTime GetDateTime(ulong timestamp)
		{
			return default(DateTime);
		}

		// Token: 0x06003727 RID: 14119 RVA: 0x000110B8 File Offset: 0x0000F2B8
		[Token(Token = "0x6003727")]
		[Address(RVA = "0x25EE3E0", Offset = "0x25EE3E0", VA = "0x7BBCDEE3E0")]
		public static DateTime GetCurrentChinaStandardDateTime()
		{
			return default(DateTime);
		}

		// Token: 0x06003728 RID: 14120 RVA: 0x000110D0 File Offset: 0x0000F2D0
		[Token(Token = "0x6003728")]
		[Address(RVA = "0x25EE4FC", Offset = "0x25EE4FC", VA = "0x7BBCDEE4FC")]
		public static DateTime GetRegionServerDateTime(long region_timezone_offset_secs)
		{
			return default(DateTime);
		}

		// Token: 0x06003729 RID: 14121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003729")]
		[Address(RVA = "0x25EE5A8", Offset = "0x25EE5A8", VA = "0x7BBCDEE5A8")]
		public static void SetServerTimeDelta(ulong serverTime)
		{
		}

		// Token: 0x0600372A RID: 14122 RVA: 0x000110E8 File Offset: 0x0000F2E8
		[Token(Token = "0x600372A")]
		[Address(RVA = "0x25EE090", Offset = "0x25EE090", VA = "0x7BBCDEE090")]
		public static int ConvertDateTimeToTimeStamp(DateTime dateTime)
		{
			return 0;
		}

		// Token: 0x0600372B RID: 14123 RVA: 0x00011100 File Offset: 0x0000F300
		[Token(Token = "0x600372B")]
		[Address(RVA = "0x25EE1C8", Offset = "0x25EE1C8", VA = "0x7BBCDEE1C8")]
		public static double ConvertDataTimeToTimsStampMilliseconds(DateTime dateTime)
		{
			return 0.0;
		}

		// Token: 0x0600372C RID: 14124 RVA: 0x00011118 File Offset: 0x0000F318
		[Token(Token = "0x600372C")]
		[Address(RVA = "0x25EE61C", Offset = "0x25EE61C", VA = "0x7BBCDEE61C")]
		public static DateTime CovertUtcDateTimeToCurrentTimeZoneDateTime(DateTime utcTime)
		{
			return default(DateTime);
		}

		// Token: 0x0600372D RID: 14125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600372D")]
		[Address(RVA = "0x25EE644", Offset = "0x25EE644", VA = "0x7BBCDEE644")]
		public static string ConvertDateTimeToYMD(DateTime time)
		{
			return null;
		}

		// Token: 0x0600372E RID: 14126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600372E")]
		[Address(RVA = "0x25EE724", Offset = "0x25EE724", VA = "0x7BBCDEE724")]
		public static string ConvertDateTimeToMD(DateTime time)
		{
			return null;
		}

		// Token: 0x0600372F RID: 14127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600372F")]
		[Address(RVA = "0x25EE7D8", Offset = "0x25EE7D8", VA = "0x7BBCDEE7D8")]
		public static string ConvertDateTimeToHM(DateTime time)
		{
			return null;
		}

		// Token: 0x06003730 RID: 14128 RVA: 0x00011130 File Offset: 0x0000F330
		[Token(Token = "0x6003730")]
		[Address(RVA = "0x25EE88C", Offset = "0x25EE88C", VA = "0x7BBCDEE88C")]
		public static DateTime CovertChinaStandardDateTimeToCurrentTimeZoneDateTime(DateTime chinaTime)
		{
			return default(DateTime);
		}

		// Token: 0x06003731 RID: 14129 RVA: 0x00011148 File Offset: 0x0000F348
		[Token(Token = "0x6003731")]
		[Address(RVA = "0x25EE948", Offset = "0x25EE948", VA = "0x7BBCDEE948")]
		public static DateTime CovertUtcDateTimeToChinaStandardDateTime(DateTime utcTime)
		{
			return default(DateTime);
		}

		// Token: 0x06003732 RID: 14130 RVA: 0x00011160 File Offset: 0x0000F360
		[Token(Token = "0x6003732")]
		[Address(RVA = "0x25EE91C", Offset = "0x25EE91C", VA = "0x7BBCDEE91C")]
		public static DateTime CovertChinaStandardDateTimeToUtcDateTime(DateTime chinaTime)
		{
			return default(DateTime);
		}

		// Token: 0x06003733 RID: 14131 RVA: 0x00011178 File Offset: 0x0000F378
		[Token(Token = "0x6003733")]
		[Address(RVA = "0x25EE444", Offset = "0x25EE444", VA = "0x7BBCDEE444")]
		public static DateTime CovertTimeSpanToChinaStandardDateTime(double timeSpan)
		{
			return default(DateTime);
		}

		// Token: 0x06003734 RID: 14132 RVA: 0x00011190 File Offset: 0x0000F390
		[Token(Token = "0x6003734")]
		[Address(RVA = "0x25EE974", Offset = "0x25EE974", VA = "0x7BBCDEE974")]
		public static DateTime CovertTimeSpanToDateTime(double timeSpan)
		{
			return default(DateTime);
		}

		// Token: 0x06003735 RID: 14133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003735")]
		[Address(RVA = "0x25EE9D4", Offset = "0x25EE9D4", VA = "0x7BBCDEE9D4")]
		public static string FormatTimeStampShort(double timeStamp)
		{
			return null;
		}

		// Token: 0x06003736 RID: 14134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003736")]
		[Address(RVA = "0x25EEC94", Offset = "0x25EEC94", VA = "0x7BBCDEEC94")]
		public static string FormatTimeStampItem(double timeStamp, bool isBefore = false)
		{
			return null;
		}

		// Token: 0x06003737 RID: 14135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003737")]
		[Address(RVA = "0x25EF00C", Offset = "0x25EF00C", VA = "0x7BBCDEF00C")]
		public static string FormatTimeStampCD(double timeStamp, bool isBefore = false, bool needSec = true)
		{
			return null;
		}

		// Token: 0x06003738 RID: 14136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003738")]
		[Address(RVA = "0x25EF7B4", Offset = "0x25EF7B4", VA = "0x7BBCDEF7B4")]
		public static string FormatShortTimeStampCD(double timeStamp)
		{
			return null;
		}

		// Token: 0x06003739 RID: 14137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003739")]
		[Address(RVA = "0x25EFA38", Offset = "0x25EFA38", VA = "0x7BBCDEFA38")]
		public static string FormatFuzzyTimeStampCD(double timeStamp)
		{
			return null;
		}

		// Token: 0x0600373A RID: 14138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600373A")]
		[Address(RVA = "0x25EFCD8", Offset = "0x25EFCD8", VA = "0x7BBCDEFCD8")]
		public static string TimeStampCD(double timeStamp)
		{
			return null;
		}

		// Token: 0x0600373B RID: 14139 RVA: 0x000111A8 File Offset: 0x0000F3A8
		[Token(Token = "0x600373B")]
		[Address(RVA = "0x25EFD70", Offset = "0x25EFD70", VA = "0x7BBCDEFD70")]
		public static int GetCurrentLocalTimeInDay()
		{
			return 0;
		}

		// Token: 0x0600373C RID: 14140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600373C")]
		[Address(RVA = "0x25EFE44", Offset = "0x25EFE44", VA = "0x7BBCDEFE44")]
		public static string ChatSendTime(ulong timeStamp)
		{
			return null;
		}

		// Token: 0x0600373D RID: 14141 RVA: 0x000111C0 File Offset: 0x0000F3C0
		[Token(Token = "0x600373D")]
		[Address(RVA = "0x25F0244", Offset = "0x25F0244", VA = "0x7BBCDF0244")]
		public static bool IsBetweenStartEndTime(ulong startStamp, ulong endStamp)
		{
			return default(bool);
		}

		// Token: 0x0600373E RID: 14142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600373E")]
		[Address(RVA = "0x25F02F0", Offset = "0x25F02F0", VA = "0x7BBCDF02F0")]
		public static string ToString(DateTime dateTime, string formatStr)
		{
			return null;
		}

		// Token: 0x0600373F RID: 14143 RVA: 0x000111D8 File Offset: 0x0000F3D8
		[Token(Token = "0x600373F")]
		[Address(RVA = "0x25F0378", Offset = "0x25F0378", VA = "0x7BBCDF0378")]
		public static DateTime ConverToDateTime(string formatStr)
		{
			return default(DateTime);
		}

		// Token: 0x040049DB RID: 18907
		[Token(Token = "0x40049DB")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int SECONDS_DAILY;

		// Token: 0x040049DC RID: 18908
		[Token(Token = "0x40049DC")]
		[FieldOffset(Offset = "0x4")]
		public static readonly int SECONDS_HOUR;

		// Token: 0x040049DD RID: 18909
		[Token(Token = "0x40049DD")]
		[FieldOffset(Offset = "0x8")]
		public static readonly int SECONDS_MINUTE;

		// Token: 0x040049DE RID: 18910
		[Token(Token = "0x40049DE")]
		[FieldOffset(Offset = "0xC")]
		public static readonly int MICROSECONDS_PER_SECOND;

		// Token: 0x040049DF RID: 18911
		[Token(Token = "0x40049DF")]
		[FieldOffset(Offset = "0x10")]
		public static readonly int MILLISECONDS_PER_SECOND;

		// Token: 0x040049E0 RID: 18912
		[Token(Token = "0x40049E0")]
		private const string TIME_FORMAT_MD = "{0:D2}.{1:D2}";

		// Token: 0x040049E1 RID: 18913
		[Token(Token = "0x40049E1")]
		private const string TIME_FORMAT_YMD = "{0:D2}.{1:D2}.{2:D2}";

		// Token: 0x040049E2 RID: 18914
		[Token(Token = "0x40049E2")]
		private const string TIME_FORMAT_HMS = "{0:D2}:{1:D2}:{2:D2}";

		// Token: 0x040049E3 RID: 18915
		[Token(Token = "0x40049E3")]
		private const string TIME_FORMAT_HM = "{0:D2}:{1:D2}";

		// Token: 0x040049E4 RID: 18916
		[Token(Token = "0x40049E4")]
		private const string DAY_STRING = "TXT_IVENTORY_OUTEXPIRE_TIME_3";

		// Token: 0x040049E5 RID: 18917
		[Token(Token = "0x40049E5")]
		private const string MINUTES_AGO_STRING = "TXT_OB5_TIME_MINUTE";

		// Token: 0x040049E6 RID: 18918
		[Token(Token = "0x40049E6")]
		private const string HOURS_AGO_STRING = "TXT_OB5_TIME_HOUR";

		// Token: 0x040049E7 RID: 18919
		[Token(Token = "0x40049E7")]
		private const string DAYS_AGO_STRING = "TXT_OB5_TIME_WEEK";

		// Token: 0x040049E8 RID: 18920
		[Token(Token = "0x40049E8")]
		private const string ONE_WEEKS_AGO_STRING = "TXT_OB5_TIME_LONGTIME";

		// Token: 0x040049E9 RID: 18921
		[Token(Token = "0x40049E9")]
		private const string TODAY_STRING = "TXT_CHAT_TIME_TODAY";

		// Token: 0x040049EA RID: 18922
		[Token(Token = "0x40049EA")]
		private const string YESTERDAY_STRING = "TXT_CHAT_TIME_YESTERDAY";

		// Token: 0x040049EB RID: 18923
		[Token(Token = "0x40049EB")]
		private const string BEFORE_STRING = "TXT_CHAT_TIME_BEFORE";

		// Token: 0x040049EC RID: 18924
		[Token(Token = "0x40049EC")]
		[FieldOffset(Offset = "0x18")]
		private static DateTime utcStartDataTime;

		// Token: 0x040049ED RID: 18925
		[Token(Token = "0x40049ED")]
		[FieldOffset(Offset = "0x20")]
		private static ulong serverTimeDelta;
	}
}
