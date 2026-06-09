using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using tcp;

namespace COW
{
	// Token: 0x02001B74 RID: 7028
	[Token(Token = "0x2001B74")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FA174", Offset = "0x10FA174")]
	public class UIRoomSinglePlayerItemController : UIEasyListItemController
	{
		// Token: 0x06009754 RID: 38740 RVA: 0x00027EE8 File Offset: 0x000260E8
		[Token(Token = "0x6009754")]
		[Address(RVA = "0x1A23648", Offset = "0x1A23648", VA = "0x7BBC223648")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009755 RID: 38741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009755")]
		[Address(RVA = "0x1A23698", Offset = "0x1A23698", VA = "0x7BBC223698", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009756 RID: 38742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009756")]
		[Address(RVA = "0x1A23854", Offset = "0x1A23854", VA = "0x7BBC223854", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06009757 RID: 38743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009757")]
		[Address(RVA = "0x1A23920", Offset = "0x1A23920", VA = "0x7BBC223920", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06009758 RID: 38744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009758")]
		[Address(RVA = "0x1A23C94", Offset = "0x1A23C94", VA = "0x7BBC223C94")]
		private void OnSelectedChanged(params object[] data)
		{
		}

		// Token: 0x06009759 RID: 38745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009759")]
		[Address(RVA = "0x1A23D7C", Offset = "0x1A23D7C", VA = "0x7BBC223D7C")]
		public UIRoomSinglePlayerItemController()
		{
		}

		// Token: 0x04009F8D RID: 40845
		[Token(Token = "0x4009F8D")]
		[FieldOffset(Offset = "0x70")]
		private UIRoomSinglePlayerItemView m_View;

		// Token: 0x04009F8E RID: 40846
		[Token(Token = "0x4009F8E")]
		[FieldOffset(Offset = "0x78")]
		private RoomGroupInfo m_info;

		// Token: 0x04009F8F RID: 40847
		[Token(Token = "0x4009F8F")]
		[FieldOffset(Offset = "0x80")]
		private List<UIRoomPlayerItemController> m_PlayerCtrls;

		// Token: 0x04009F90 RID: 40848
		[Token(Token = "0x4009F90")]
		[FieldOffset(Offset = "0x88")]
		private int m_Index;
	}
}
