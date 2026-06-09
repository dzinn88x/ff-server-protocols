using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B3D RID: 6973
	[Token(Token = "0x2001B3D")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F98CC", Offset = "0x10F98CC")]
	public class UIRankGuideController : UIBaseController
	{
		// Token: 0x060095B6 RID: 38326 RVA: 0x00027960 File Offset: 0x00025B60
		[Token(Token = "0x60095B6")]
		[Address(RVA = "0x1E0C26C", Offset = "0x1E0C26C", VA = "0x7BBC60C26C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060095B7 RID: 38327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095B7")]
		[Address(RVA = "0x1E0C2BC", Offset = "0x1E0C2BC", VA = "0x7BBC60C2BC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060095B8 RID: 38328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095B8")]
		[Address(RVA = "0x1E0C414", Offset = "0x1E0C414", VA = "0x7BBC60C414", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060095B9 RID: 38329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095B9")]
		[Address(RVA = "0x1E0C41C", Offset = "0x1E0C41C", VA = "0x7BBC60C41C")]
		public void SetGuideView(UIGuideType type, string label_text, bool showMapBtnAnim = true)
		{
		}

		// Token: 0x060095BA RID: 38330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095BA")]
		[Address(RVA = "0x1E0C324", Offset = "0x1E0C324", VA = "0x7BBC60C324")]
		private void RefreshView()
		{
		}

		// Token: 0x060095BB RID: 38331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095BB")]
		[Address(RVA = "0x1E0C580", Offset = "0x1E0C580", VA = "0x7BBC60C580")]
		public void PlayUnlockAnim()
		{
		}

		// Token: 0x060095BC RID: 38332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095BC")]
		[Address(RVA = "0x1E0C5C4", Offset = "0x1E0C5C4", VA = "0x7BBC60C5C4")]
		public UIRankGuideController()
		{
		}

		// Token: 0x04009EBF RID: 40639
		[Token(Token = "0x4009EBF")]
		[FieldOffset(Offset = "0x58")]
		private UIRankGuideView m_View;

		// Token: 0x04009EC0 RID: 40640
		[Token(Token = "0x4009EC0")]
		[FieldOffset(Offset = "0x60")]
		private UIModelLadderMatch m_LadderModel;

		// Token: 0x04009EC1 RID: 40641
		[Token(Token = "0x4009EC1")]
		[FieldOffset(Offset = "0x68")]
		private string label_tips_str;
	}
}
