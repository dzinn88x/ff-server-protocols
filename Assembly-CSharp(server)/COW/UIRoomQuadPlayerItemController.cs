using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using tcp;

namespace COW
{
	// Token: 0x02001B71 RID: 7025
	[Token(Token = "0x2001B71")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FA0CC", Offset = "0x10FA0CC")]
	public class UIRoomQuadPlayerItemController : UIEasyListItemController
	{
		// Token: 0x06009745 RID: 38725 RVA: 0x00027EA0 File Offset: 0x000260A0
		[Token(Token = "0x6009745")]
		[Address(RVA = "0x1A21640", Offset = "0x1A21640", VA = "0x7BBC221640")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009746 RID: 38726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009746")]
		[Address(RVA = "0x1A21690", Offset = "0x1A21690", VA = "0x7BBC221690", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009747 RID: 38727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009747")]
		[Address(RVA = "0x1A219AC", Offset = "0x1A219AC", VA = "0x7BBC2219AC", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06009748 RID: 38728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009748")]
		[Address(RVA = "0x1A21CB4", Offset = "0x1A21CB4", VA = "0x7BBC221CB4")]
		public UIRoomQuadPlayerItemController()
		{
		}

		// Token: 0x04009F83 RID: 40835
		[Token(Token = "0x4009F83")]
		[FieldOffset(Offset = "0x70")]
		private UIRoomQuadPlayerItemView m_View;

		// Token: 0x04009F84 RID: 40836
		[Token(Token = "0x4009F84")]
		[FieldOffset(Offset = "0x78")]
		private List<RoomPlayerInfo> m_Members;

		// Token: 0x04009F85 RID: 40837
		[Token(Token = "0x4009F85")]
		[FieldOffset(Offset = "0x80")]
		private List<UIRoomPlayerItemController> m_PlayerCtrls;

		// Token: 0x04009F86 RID: 40838
		[Token(Token = "0x4009F86")]
		[FieldOffset(Offset = "0x88")]
		private int m_Index;
	}
}
