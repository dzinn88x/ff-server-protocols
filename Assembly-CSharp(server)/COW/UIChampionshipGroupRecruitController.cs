using System;
using System.Text;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200147D RID: 5245
	[Token(Token = "0x200147D")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ECEF4", Offset = "0x10ECEF4")]
	public class UIChampionshipGroupRecruitController : UIPopupWindowController
	{
		// Token: 0x06005878 RID: 22648 RVA: 0x0001A130 File Offset: 0x00018330
		[Token(Token = "0x6005878")]
		[Address(RVA = "0x1EC30AC", Offset = "0x1EC30AC", VA = "0x7BBC6C30AC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005879 RID: 22649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005879")]
		[Address(RVA = "0x1EC30FC", Offset = "0x1EC30FC", VA = "0x7BBC6C30FC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600587A RID: 22650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600587A")]
		[Address(RVA = "0x1EC3D74", Offset = "0x1EC3D74", VA = "0x7BBC6C3D74")]
		public void SetChampionshipInfo(uint type, uint id)
		{
		}

		// Token: 0x0600587B RID: 22651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600587B")]
		[Address(RVA = "0x1EC3EA4", Offset = "0x1EC3EA4", VA = "0x7BBC6C3EA4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600587C RID: 22652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600587C")]
		[Address(RVA = "0x1EC35FC", Offset = "0x1EC35FC", VA = "0x7BBC6C35FC")]
		private void DefaultWorldState()
		{
		}

		// Token: 0x0600587D RID: 22653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600587D")]
		[Address(RVA = "0x1EC3784", Offset = "0x1EC3784", VA = "0x7BBC6C3784")]
		private void UpdateView()
		{
		}

		// Token: 0x0600587E RID: 22654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600587E")]
		[Address(RVA = "0x1EC3F4C", Offset = "0x1EC3F4C", VA = "0x7BBC6C3F4C")]
		private void OnSendClick()
		{
		}

		// Token: 0x0600587F RID: 22655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600587F")]
		[Address(RVA = "0x1EC3B08", Offset = "0x1EC3B08", VA = "0x7BBC6C3B08")]
		private void OnChannelToggleChange()
		{
		}

		// Token: 0x06005880 RID: 22656 RVA: 0x0001A148 File Offset: 0x00018348
		[Token(Token = "0x6005880")]
		[Address(RVA = "0x1EC430C", Offset = "0x1EC430C", VA = "0x7BBC6C430C")]
		private bool CheckSendToValid()
		{
			return default(bool);
		}

		// Token: 0x06005881 RID: 22657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005881")]
		[Address(RVA = "0x1EC4390", Offset = "0x1EC4390", VA = "0x7BBC6C4390")]
		public UIChampionshipGroupRecruitController()
		{
		}

		// Token: 0x04007C56 RID: 31830
		[Token(Token = "0x4007C56")]
		[FieldOffset(Offset = "0x98")]
		private UIChampionshipChatRecruitView m_View;

		// Token: 0x04007C57 RID: 31831
		[Token(Token = "0x4007C57")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelChat m_ChatModel;

		// Token: 0x04007C58 RID: 31832
		[Token(Token = "0x4007C58")]
		[FieldOffset(Offset = "0xA8")]
		private UIModelChampionship m_ModelChampionship;

		// Token: 0x04007C59 RID: 31833
		[Token(Token = "0x4007C59")]
		[FieldOffset(Offset = "0xB0")]
		private StringBuilder m_Builder;

		// Token: 0x04007C5A RID: 31834
		[Token(Token = "0x4007C5A")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_LastInCDState;

		// Token: 0x04007C5B RID: 31835
		[Token(Token = "0x4007C5B")]
		[FieldOffset(Offset = "0xBC")]
		private uint m_WorldDelayCallID;

		// Token: 0x04007C5C RID: 31836
		[Token(Token = "0x4007C5C")]
		[FieldOffset(Offset = "0xC0")]
		private readonly float GREY_ALPHA;

		// Token: 0x04007C5D RID: 31837
		[Token(Token = "0x4007C5D")]
		[FieldOffset(Offset = "0xC4")]
		private uint m_ChampionshipType;

		// Token: 0x04007C5E RID: 31838
		[Token(Token = "0x4007C5E")]
		[FieldOffset(Offset = "0xC8")]
		private uint m_ChampionshipID;
	}
}
