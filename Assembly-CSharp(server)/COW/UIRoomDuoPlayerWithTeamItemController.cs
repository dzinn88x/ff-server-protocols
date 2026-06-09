using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using tcp;

namespace COW
{
	// Token: 0x02001B62 RID: 7010
	[Token(Token = "0x2001B62")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F9EA4", Offset = "0x10F9EA4")]
	public class UIRoomDuoPlayerWithTeamItemController : UIEasyListItemController
	{
		// Token: 0x060096B7 RID: 38583 RVA: 0x00027D38 File Offset: 0x00025F38
		[Token(Token = "0x60096B7")]
		[Address(RVA = "0x1A10920", Offset = "0x1A10920", VA = "0x7BBC210920")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060096B8 RID: 38584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096B8")]
		[Address(RVA = "0x1A10970", Offset = "0x1A10970", VA = "0x7BBC210970", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060096B9 RID: 38585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096B9")]
		[Address(RVA = "0x1A10BD0", Offset = "0x1A10BD0", VA = "0x7BBC210BD0", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x060096BA RID: 38586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096BA")]
		[Address(RVA = "0x1A10C9C", Offset = "0x1A10C9C", VA = "0x7BBC210C9C", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x060096BB RID: 38587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096BB")]
		[Address(RVA = "0x1A11E8C", Offset = "0x1A11E8C", VA = "0x7BBC211E8C")]
		private void OnSelectedChanged(params object[] data)
		{
		}

		// Token: 0x060096BC RID: 38588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096BC")]
		[Address(RVA = "0x1A11F74", Offset = "0x1A11F74", VA = "0x7BBC211F74")]
		public UIRoomDuoPlayerWithTeamItemController()
		{
		}

		// Token: 0x04009F2B RID: 40747
		[Token(Token = "0x4009F2B")]
		[FieldOffset(Offset = "0x70")]
		private UIRoomDuoPlayerWithTeamItemView m_View;

		// Token: 0x04009F2C RID: 40748
		[Token(Token = "0x4009F2C")]
		[FieldOffset(Offset = "0x78")]
		private List<RoomPlayerInfo> m_Members;

		// Token: 0x04009F2D RID: 40749
		[Token(Token = "0x4009F2D")]
		[FieldOffset(Offset = "0x80")]
		private List<UIRoomPlayerItemController> m_PlayerCtrls;

		// Token: 0x04009F2E RID: 40750
		[Token(Token = "0x4009F2E")]
		[FieldOffset(Offset = "0x88")]
		private int m_Index;
	}
}
