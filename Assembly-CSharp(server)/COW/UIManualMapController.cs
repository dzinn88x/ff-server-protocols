using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001A4A RID: 6730
	[Token(Token = "0x2001A4A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F7E34", Offset = "0x10F7E34")]
	public class UIManualMapController : UIManualContentBaseController
	{
		// Token: 0x06008D7B RID: 36219 RVA: 0x00025B00 File Offset: 0x00023D00
		[Token(Token = "0x6008D7B")]
		[Address(RVA = "0x1DFEC54", Offset = "0x1DFEC54", VA = "0x7BBC5FEC54")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008D7C RID: 36220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D7C")]
		[Address(RVA = "0x1DFECA4", Offset = "0x1DFECA4", VA = "0x7BBC5FECA4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008D7D RID: 36221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D7D")]
		[Address(RVA = "0x1DFEEAC", Offset = "0x1DFEEAC", VA = "0x7BBC5FEEAC", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06008D7E RID: 36222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D7E")]
		[Address(RVA = "0x1DFEEB4", Offset = "0x1DFEEB4", VA = "0x7BBC5FEEB4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008D7F RID: 36223 RVA: 0x00025B18 File Offset: 0x00023D18
		[Token(Token = "0x6008D7F")]
		[Address(RVA = "0x1DFEEE8", Offset = "0x1DFEEE8", VA = "0x7BBC5FEEE8", Slot = "31")]
		protected override int GetMaxPage()
		{
			return 0;
		}

		// Token: 0x06008D80 RID: 36224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D80")]
		[Address(RVA = "0x1DFEF5C", Offset = "0x1DFEF5C", VA = "0x7BBC5FEF5C", Slot = "28")]
		public override void SetData(UIManualDataBase data)
		{
		}

		// Token: 0x06008D81 RID: 36225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D81")]
		[Address(RVA = "0x1DFF004", Offset = "0x1DFF004", VA = "0x7BBC5FF004", Slot = "30")]
		public override void RefreshView()
		{
		}

		// Token: 0x06008D82 RID: 36226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D82")]
		[Address(RVA = "0x1DFF438", Offset = "0x1DFF438", VA = "0x7BBC5FF438")]
		private void CreateDebris(UIManualMapDebrisData data)
		{
		}

		// Token: 0x06008D83 RID: 36227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008D83")]
		[Address(RVA = "0x1DFF900", Offset = "0x1DFF900", VA = "0x7BBC5FF900")]
		public UIManualMapController()
		{
		}

		// Token: 0x04009978 RID: 39288
		[Token(Token = "0x4009978")]
		[FieldOffset(Offset = "0x78")]
		private UIManualMapView m_View;

		// Token: 0x04009979 RID: 39289
		[Token(Token = "0x4009979")]
		[FieldOffset(Offset = "0x80")]
		private UIManualMapDebrisData m_DebrisData;

		// Token: 0x0400997A RID: 39290
		[Token(Token = "0x400997A")]
		[FieldOffset(Offset = "0x88")]
		private UIManualMapDebrisController m_LeftCtrl;

		// Token: 0x0400997B RID: 39291
		[Token(Token = "0x400997B")]
		[FieldOffset(Offset = "0x90")]
		private UIManualMapDebrisController m_RightCtrl;

		// Token: 0x0400997C RID: 39292
		[Token(Token = "0x400997C")]
		[FieldOffset(Offset = "0x98")]
		private List<UIManualMapDebrisController> m_DebrisCtrlList;

		// Token: 0x0400997D RID: 39293
		[Token(Token = "0x400997D")]
		[FieldOffset(Offset = "0xA0")]
		private GameObject m_LeftArrowTips;

		// Token: 0x0400997E RID: 39294
		[Token(Token = "0x400997E")]
		[FieldOffset(Offset = "0xA8")]
		private GameObject m_RightArrowTips;

		// Token: 0x0400997F RID: 39295
		[Token(Token = "0x400997F")]
		[FieldOffset(Offset = "0xB0")]
		private List<UIManualMapDebrisController.MapType> m_MapTypes;
	}
}
