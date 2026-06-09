using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B39 RID: 6969
	[Token(Token = "0x2001B39")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F9824", Offset = "0x10F9824")]
	public class UIRankComparisonController : UIPopupWindowController
	{
		// Token: 0x060095A0 RID: 38304 RVA: 0x00027918 File Offset: 0x00025B18
		[Token(Token = "0x60095A0")]
		[Address(RVA = "0x1E0A51C", Offset = "0x1E0A51C", VA = "0x7BBC60A51C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060095A1 RID: 38305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095A1")]
		[Address(RVA = "0x1E0A56C", Offset = "0x1E0A56C", VA = "0x7BBC60A56C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060095A2 RID: 38306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095A2")]
		[Address(RVA = "0x1E0B154", Offset = "0x1E0B154", VA = "0x7BBC60B154", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x060095A3 RID: 38307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095A3")]
		[Address(RVA = "0x1E0AC64", Offset = "0x1E0AC64", VA = "0x7BBC60AC64")]
		private void InitLadderInfo()
		{
		}

		// Token: 0x060095A4 RID: 38308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095A4")]
		[Address(RVA = "0x1E0AF34", Offset = "0x1E0AF34", VA = "0x7BBC60AF34")]
		private void InitRankListInfo()
		{
		}

		// Token: 0x060095A5 RID: 38309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095A5")]
		[Address(RVA = "0x1E0B1F8", Offset = "0x1E0B1F8", VA = "0x7BBC60B1F8")]
		private void OnBGClick()
		{
		}

		// Token: 0x060095A6 RID: 38310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095A6")]
		[Address(RVA = "0x1E0B200", Offset = "0x1E0B200", VA = "0x7BBC60B200")]
		private void OnGotoClick()
		{
		}

		// Token: 0x060095A7 RID: 38311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095A7")]
		[Address(RVA = "0x1E0B278", Offset = "0x1E0B278", VA = "0x7BBC60B278")]
		private void OnShowClick()
		{
		}

		// Token: 0x060095A8 RID: 38312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095A8")]
		[Address(RVA = "0x1E0B318", Offset = "0x1E0B318", VA = "0x7BBC60B318", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x060095A9 RID: 38313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095A9")]
		[Address(RVA = "0x1E0B320", Offset = "0x1E0B320", VA = "0x7BBC60B320")]
		private void OnShareClick()
		{
		}

		// Token: 0x060095AA RID: 38314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095AA")]
		[Address(RVA = "0x1E0B404", Offset = "0x1E0B404", VA = "0x7BBC60B404", Slot = "23")]
		public override void BeforeScreenshot()
		{
		}

		// Token: 0x060095AB RID: 38315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095AB")]
		[Address(RVA = "0x1E0B514", Offset = "0x1E0B514", VA = "0x7BBC60B514", Slot = "24")]
		public override void AfterScreenshot()
		{
		}

		// Token: 0x060095AC RID: 38316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095AC")]
		[Address(RVA = "0x1E0B66C", Offset = "0x1E0B66C", VA = "0x7BBC60B66C")]
		public UIRankComparisonController()
		{
		}

		// Token: 0x04009EB5 RID: 40629
		[Token(Token = "0x4009EB5")]
		[FieldOffset(Offset = "0x98")]
		private UIRankComparisonView m_View;

		// Token: 0x04009EB6 RID: 40630
		[Token(Token = "0x4009EB6")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelLadderMatch m_Model;

		// Token: 0x04009EB7 RID: 40631
		[Token(Token = "0x4009EB7")]
		[FieldOffset(Offset = "0xA8")]
		private List<UIRankComparisonFriendListItemController> m_ItemList;
	}
}
