using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001C7C RID: 7292
	[Token(Token = "0x2001C7C")]
	public class LocStyleConfigDataManager : SingletonModule<LocStyleConfigDataManager>
	{
		// Token: 0x06009F03 RID: 40707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F03")]
		[Address(RVA = "0x1A4E5D0", Offset = "0x1A4E5D0", VA = "0x7BBC24E5D0", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x06009F04 RID: 40708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F04")]
		[Address(RVA = "0x1A4E630", Offset = "0x1A4E630", VA = "0x7BBC24E630", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x06009F05 RID: 40709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F05")]
		[Address(RVA = "0x1A4E634", Offset = "0x1A4E634", VA = "0x7BBC24E634")]
		public void ProcessData(List<CSVBaseData> lstData)
		{
		}

		// Token: 0x06009F06 RID: 40710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009F06")]
		[Address(RVA = "0x1A4E638", Offset = "0x1A4E638", VA = "0x7BBC24E638")]
		public LocStyleConfigData GetConfigDataByLocLang(LocLang lang)
		{
			return null;
		}

		// Token: 0x06009F07 RID: 40711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009F07")]
		[Address(RVA = "0x1A4E6C0", Offset = "0x1A4E6C0", VA = "0x7BBC24E6C0")]
		public LocStyleConfigDataManager()
		{
		}

		// Token: 0x0400A5EF RID: 42479
		[Token(Token = "0x400A5EF")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<LocLang, LocStyleConfigData> m_LocStyleConfigDataDic;
	}
}
