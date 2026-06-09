using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001A4E RID: 6734
	[Token(Token = "0x2001A4E")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F7EB4", Offset = "0x10F7EB4")]
	public class UIManualMapDebrisDetailController : UIPopupWindowController
	{
		// Token: 0x06008DA3 RID: 36259 RVA: 0x00025BD8 File Offset: 0x00023DD8
		[Token(Token = "0x6008DA3")]
		[Address(RVA = "0x1E036EC", Offset = "0x1E036EC", VA = "0x7BBC6036EC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008DA4 RID: 36260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DA4")]
		[Address(RVA = "0x1E0373C", Offset = "0x1E0373C", VA = "0x7BBC60373C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008DA5 RID: 36261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DA5")]
		[Address(RVA = "0x1E03820", Offset = "0x1E03820", VA = "0x7BBC603820", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06008DA6 RID: 36262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DA6")]
		[Address(RVA = "0x1E03828", Offset = "0x1E03828", VA = "0x7BBC603828", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008DA7 RID: 36263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DA7")]
		[Address(RVA = "0x1E03850", Offset = "0x1E03850", VA = "0x7BBC603850")]
		private void OnClickClose()
		{
		}

		// Token: 0x06008DA8 RID: 36264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DA8")]
		[Address(RVA = "0x1E0216C", Offset = "0x1E0216C", VA = "0x7BBC60216C")]
		public void SetData(UIManualMapDebrisController.MapType type, Texture tex, List<ManualMapData> data)
		{
		}

		// Token: 0x06008DA9 RID: 36265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DA9")]
		[Address(RVA = "0x1E021DC", Offset = "0x1E021DC", VA = "0x7BBC6021DC")]
		public void RefreshView(bool isAllUnlock)
		{
		}

		// Token: 0x06008DAA RID: 36266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DAA")]
		[Address(RVA = "0x1E03858", Offset = "0x1E03858", VA = "0x7BBC603858")]
		private void InitSign(UIManualMapDebrisController.MapType type)
		{
		}

		// Token: 0x06008DAB RID: 36267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DAB")]
		[Address(RVA = "0x1E04658", Offset = "0x1E04658", VA = "0x7BBC604658")]
		private void RefreshSignView()
		{
		}

		// Token: 0x06008DAC RID: 36268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DAC")]
		[Address(RVA = "0x1E048CC", Offset = "0x1E048CC", VA = "0x7BBC6048CC")]
		public UIManualMapDebrisDetailController()
		{
		}

		// Token: 0x04009991 RID: 39313
		[Token(Token = "0x4009991")]
		[FieldOffset(Offset = "0x98")]
		private UIManualMapDebrisDetailView m_View;

		// Token: 0x04009992 RID: 39314
		[Token(Token = "0x4009992")]
		[FieldOffset(Offset = "0xA0")]
		private List<UISprite> m_SignList;

		// Token: 0x04009993 RID: 39315
		[Token(Token = "0x4009993")]
		[FieldOffset(Offset = "0xA8")]
		private List<ManualMapData> m_UnlockMapDataList;

		// Token: 0x04009994 RID: 39316
		[Token(Token = "0x4009994")]
		[FieldOffset(Offset = "0xB0")]
		private uint[] m_RadiusArray;

		// Token: 0x04009995 RID: 39317
		[Token(Token = "0x4009995")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_MapHasProcessed;
	}
}
