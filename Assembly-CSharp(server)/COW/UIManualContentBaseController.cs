using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001A39 RID: 6713
	[Token(Token = "0x2001A39")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F7C8C", Offset = "0x10F7C8C")]
	public class UIManualContentBaseController : UIBaseController
	{
		// Token: 0x06008CF9 RID: 36089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CF9")]
		[Address(RVA = "0x1DF5258", Offset = "0x1DF5258", VA = "0x7BBC5F5258", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008CFA RID: 36090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CFA")]
		[Address(RVA = "0x1DF5398", Offset = "0x1DF5398", VA = "0x7BBC5F5398", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008CFB RID: 36091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CFB")]
		[Address(RVA = "0x1DF52BC", Offset = "0x1DF52BC", VA = "0x7BBC5F52BC")]
		protected void AdjustWidgtDimFullScreen(UIWidget widget)
		{
		}

		// Token: 0x06008CFC RID: 36092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CFC")]
		[Address(RVA = "0x1DF53CC", Offset = "0x1DF53CC", VA = "0x7BBC5F53CC", Slot = "28")]
		public virtual void SetData(UIManualDataBase data)
		{
		}

		// Token: 0x06008CFD RID: 36093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CFD")]
		[Address(RVA = "0x1DF5404", Offset = "0x1DF5404", VA = "0x7BBC5F5404", Slot = "29")]
		public virtual void ClearData()
		{
		}

		// Token: 0x06008CFE RID: 36094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CFE")]
		[Address(RVA = "0x1DF5410", Offset = "0x1DF5410", VA = "0x7BBC5F5410", Slot = "30")]
		public virtual void RefreshView()
		{
		}

		// Token: 0x06008CFF RID: 36095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CFF")]
		[Address(RVA = "0x1DF5494", Offset = "0x1DF5494", VA = "0x7BBC5F5494")]
		public void GotoWebView(uint eventId, int eventType)
		{
		}

		// Token: 0x06008D00 RID: 36096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D00")]
		[Address(RVA = "0x1DF5898", Offset = "0x1DF5898", VA = "0x7BBC5F5898")]
		protected void OnClickPrevPage()
		{
		}

		// Token: 0x06008D01 RID: 36097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D01")]
		[Address(RVA = "0x1DF5A78", Offset = "0x1DF5A78", VA = "0x7BBC5F5A78")]
		protected void OnClickNextPage()
		{
		}

		// Token: 0x06008D02 RID: 36098 RVA: 0x00025998 File Offset: 0x00023B98
		[Token(Token = "0x6008D02")]
		[Address(RVA = "0x1DF5C54", Offset = "0x1DF5C54", VA = "0x7BBC5F5C54", Slot = "31")]
		protected virtual int GetMaxPage()
		{
			return 0;
		}

		// Token: 0x06008D03 RID: 36099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D03")]
		[Address(RVA = "0x1DF5C5C", Offset = "0x1DF5C5C", VA = "0x7BBC5F5C5C")]
		public UIManualContentBaseController()
		{
		}

		// Token: 0x0400992F RID: 39215
		[Token(Token = "0x400992F")]
		[FieldOffset(Offset = "0x58")]
		protected int[] m_LocationIds;

		// Token: 0x04009930 RID: 39216
		[Token(Token = "0x4009930")]
		[FieldOffset(Offset = "0x60")]
		protected int m_CurPage;

		// Token: 0x04009931 RID: 39217
		[Token(Token = "0x4009931")]
		[FieldOffset(Offset = "0x64")]
		protected int m_MaxPage;

		// Token: 0x04009932 RID: 39218
		[Token(Token = "0x4009932")]
		protected const int MAX_CONFIG_PAGE = 100;

		// Token: 0x04009933 RID: 39219
		[Token(Token = "0x4009933")]
		[FieldOffset(Offset = "0x68")]
		private Dictionary<EManual.EventType, string> m_UrlTypeDict;

		// Token: 0x04009934 RID: 39220
		[Token(Token = "0x4009934")]
		private const string WEB_URL_FORMAT = "{0}manual/{1}?eventId={2}&lang={3}";

		// Token: 0x04009935 RID: 39221
		[Token(Token = "0x4009935")]
		[FieldOffset(Offset = "0x70")]
		private UIManualDataBase m_BaseData;
	}
}
