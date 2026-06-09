using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B3B RID: 6971
	[Token(Token = "0x2001B3B")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F9894", Offset = "0x10F9894")]
	public class UIRankComparisonFriendsBoxController : UIPopupWindowController
	{
		// Token: 0x060095B2 RID: 38322 RVA: 0x00027948 File Offset: 0x00025B48
		[Token(Token = "0x60095B2")]
		[Address(RVA = "0x1E0B918", Offset = "0x1E0B918", VA = "0x7BBC60B918")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060095B3 RID: 38323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095B3")]
		[Address(RVA = "0x1E0B968", Offset = "0x1E0B968", VA = "0x7BBC60B968", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060095B4 RID: 38324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095B4")]
		[Address(RVA = "0x1E0BA6C", Offset = "0x1E0BA6C", VA = "0x7BBC60BA6C")]
		private void RefreshUI()
		{
		}

		// Token: 0x060095B5 RID: 38325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095B5")]
		[Address(RVA = "0x1E0BC50", Offset = "0x1E0BC50", VA = "0x7BBC60BC50")]
		public UIRankComparisonFriendsBoxController()
		{
		}

		// Token: 0x04009EBA RID: 40634
		[Token(Token = "0x4009EBA")]
		[FieldOffset(Offset = "0x98")]
		private UIRankComparisonFriendsBoxView m_View;

		// Token: 0x04009EBB RID: 40635
		[Token(Token = "0x4009EBB")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelLadderMatch m_Model;
	}
}
