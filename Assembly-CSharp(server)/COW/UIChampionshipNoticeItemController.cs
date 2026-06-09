using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001487 RID: 5255
	[Token(Token = "0x2001487")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ED064", Offset = "0x10ED064")]
	public class UIChampionshipNoticeItemController : UIBaseController
	{
		// Token: 0x060058C1 RID: 22721 RVA: 0x0001A250 File Offset: 0x00018450
		[Token(Token = "0x60058C1")]
		[Address(RVA = "0x1EC81BC", Offset = "0x1EC81BC", VA = "0x7BBC6C81BC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060058C2 RID: 22722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058C2")]
		[Address(RVA = "0x1EC820C", Offset = "0x1EC820C", VA = "0x7BBC6C820C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060058C3 RID: 22723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058C3")]
		[Address(RVA = "0x1EC82F0", Offset = "0x1EC82F0", VA = "0x7BBC6C82F0", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x060058C4 RID: 22724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058C4")]
		[Address(RVA = "0x1EC7880", Offset = "0x1EC7880", VA = "0x7BBC6C7880")]
		public void RefreshView(string url, uint goPos)
		{
		}

		// Token: 0x060058C5 RID: 22725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058C5")]
		[Address(RVA = "0x1EC82F8", Offset = "0x1EC82F8", VA = "0x7BBC6C82F8")]
		private void OnBtnNoticeItemClick()
		{
		}

		// Token: 0x060058C6 RID: 22726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058C6")]
		[Address(RVA = "0x1EC8318", Offset = "0x1EC8318", VA = "0x7BBC6C8318")]
		public UIChampionshipNoticeItemController()
		{
		}

		// Token: 0x04007C81 RID: 31873
		[Token(Token = "0x4007C81")]
		[FieldOffset(Offset = "0x58")]
		private UIChampionshipNoticeItemView m_View;

		// Token: 0x04007C82 RID: 31874
		[Token(Token = "0x4007C82")]
		[FieldOffset(Offset = "0x60")]
		private uint m_GoPos;
	}
}
