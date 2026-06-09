using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200147A RID: 5242
	[Token(Token = "0x200147A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ECE84", Offset = "0x10ECE84")]
	internal class UIChampionshipGameResultItemController : UIEasyListItemController
	{
		// Token: 0x0600585F RID: 22623 RVA: 0x0001A0D0 File Offset: 0x000182D0
		[Token(Token = "0x600585F")]
		[Address(RVA = "0x1C35450", Offset = "0x1C35450", VA = "0x7BBC435450")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005860 RID: 22624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005860")]
		[Address(RVA = "0x1C354A0", Offset = "0x1C354A0", VA = "0x7BBC4354A0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005861 RID: 22625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005861")]
		[Address(RVA = "0x1C35504", Offset = "0x1C35504", VA = "0x7BBC435504", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06005862 RID: 22626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005862")]
		[Address(RVA = "0x1C35508", Offset = "0x1C35508", VA = "0x7BBC435508")]
		public UIChampionshipGameResultItemController()
		{
		}

		// Token: 0x04007C4B RID: 31819
		[Token(Token = "0x4007C4B")]
		[FieldOffset(Offset = "0x70")]
		private UIChampionshipGameResultItemView m_View;
	}
}
