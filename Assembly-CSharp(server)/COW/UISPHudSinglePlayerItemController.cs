using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B9A RID: 7066
	[Token(Token = "0x2001B9A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FA794", Offset = "0x10FA794")]
	internal class UISPHudSinglePlayerItemController : UIEasyListItemController
	{
		// Token: 0x06009874 RID: 39028 RVA: 0x00028278 File Offset: 0x00026478
		[Token(Token = "0x6009874")]
		[Address(RVA = "0x1EF3D4C", Offset = "0x1EF3D4C", VA = "0x7BBC6F3D4C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009875 RID: 39029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009875")]
		[Address(RVA = "0x1EF3D9C", Offset = "0x1EF3D9C", VA = "0x7BBC6F3D9C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009876 RID: 39030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009876")]
		[Address(RVA = "0x1EF3EA4", Offset = "0x1EF3EA4", VA = "0x7BBC6F3EA4")]
		private void SelectedPlayer(object[] data)
		{
		}

		// Token: 0x06009877 RID: 39031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009877")]
		[Address(RVA = "0x1EF3FC4", Offset = "0x1EF3FC4", VA = "0x7BBC6F3FC4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06009878 RID: 39032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009878")]
		[Address(RVA = "0x1EEAA18", Offset = "0x1EEAA18", VA = "0x7BBC6EAA18")]
		public void SetPlayerInfo(PlayerData data, int index)
		{
		}

		// Token: 0x06009879 RID: 39033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009879")]
		[Address(RVA = "0x1EF4084", Offset = "0x1EF4084", VA = "0x7BBC6F4084")]
		public void UpdateKillCount(uint killcount)
		{
		}

		// Token: 0x0600987A RID: 39034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600987A")]
		[Address(RVA = "0x1EF40F8", Offset = "0x1EF40F8", VA = "0x7BBC6F40F8", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x0600987B RID: 39035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600987B")]
		[Address(RVA = "0x1EF42C0", Offset = "0x1EF42C0", VA = "0x7BBC6F42C0")]
		public UISPHudSinglePlayerItemController()
		{
		}

		// Token: 0x0400A038 RID: 41016
		[Token(Token = "0x400A038")]
		[FieldOffset(Offset = "0x70")]
		private UISPHudSinglePlayerItemView m_View;
	}
}
