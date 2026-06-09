using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using tcp;

namespace COW
{
	// Token: 0x02001B72 RID: 7026
	[Token(Token = "0x2001B72")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FA104", Offset = "0x10FA104")]
	public class UIRoomQuadPlayerWithTeamItemController : UIEasyListItemController
	{
		// Token: 0x06009749 RID: 38729 RVA: 0x00027EB8 File Offset: 0x000260B8
		[Token(Token = "0x6009749")]
		[Address(RVA = "0x1A21F0C", Offset = "0x1A21F0C", VA = "0x7BBC221F0C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600974A RID: 38730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600974A")]
		[Address(RVA = "0x1A21F5C", Offset = "0x1A21F5C", VA = "0x7BBC221F5C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600974B RID: 38731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600974B")]
		[Address(RVA = "0x1A222F4", Offset = "0x1A222F4", VA = "0x7BBC2222F4", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x0600974C RID: 38732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600974C")]
		[Address(RVA = "0x1A223C0", Offset = "0x1A223C0", VA = "0x7BBC2223C0", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x0600974D RID: 38733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600974D")]
		[Address(RVA = "0x1A22CA8", Offset = "0x1A22CA8", VA = "0x7BBC222CA8")]
		private void OnSelectedChanged(params object[] data)
		{
		}

		// Token: 0x0600974E RID: 38734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600974E")]
		[Address(RVA = "0x1A22D90", Offset = "0x1A22D90", VA = "0x7BBC222D90")]
		public UIRoomQuadPlayerWithTeamItemController()
		{
		}

		// Token: 0x04009F87 RID: 40839
		[Token(Token = "0x4009F87")]
		[FieldOffset(Offset = "0x70")]
		private UIRoomQuadPlayerWithTeamItemView m_View;

		// Token: 0x04009F88 RID: 40840
		[Token(Token = "0x4009F88")]
		[FieldOffset(Offset = "0x78")]
		private List<RoomPlayerInfo> m_Members;

		// Token: 0x04009F89 RID: 40841
		[Token(Token = "0x4009F89")]
		[FieldOffset(Offset = "0x80")]
		private List<UIRoomPlayerItemController> m_PlayerCtrls;

		// Token: 0x04009F8A RID: 40842
		[Token(Token = "0x4009F8A")]
		[FieldOffset(Offset = "0x88")]
		private int m_Index;
	}
}
