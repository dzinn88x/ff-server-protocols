using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using tcp;

namespace COW
{
	// Token: 0x02001B61 RID: 7009
	[Token(Token = "0x2001B61")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F9E6C", Offset = "0x10F9E6C")]
	public class UIRoomDuoPlayerItemController : UIEasyListItemController
	{
		// Token: 0x060096B3 RID: 38579 RVA: 0x00027D20 File Offset: 0x00025F20
		[Token(Token = "0x60096B3")]
		[Address(RVA = "0x1E23E14", Offset = "0x1E23E14", VA = "0x7BBC623E14")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060096B4 RID: 38580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096B4")]
		[Address(RVA = "0x1E23E64", Offset = "0x1E23E64", VA = "0x7BBC623E64", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060096B5 RID: 38581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096B5")]
		[Address(RVA = "0x1E24048", Offset = "0x1E24048", VA = "0x7BBC624048", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x060096B6 RID: 38582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096B6")]
		[Address(RVA = "0x1E24354", Offset = "0x1E24354", VA = "0x7BBC624354")]
		public UIRoomDuoPlayerItemController()
		{
		}

		// Token: 0x04009F27 RID: 40743
		[Token(Token = "0x4009F27")]
		[FieldOffset(Offset = "0x70")]
		private UIRoomDuoPlayerItemView m_View;

		// Token: 0x04009F28 RID: 40744
		[Token(Token = "0x4009F28")]
		[FieldOffset(Offset = "0x78")]
		private List<RoomPlayerInfo> m_Members;

		// Token: 0x04009F29 RID: 40745
		[Token(Token = "0x4009F29")]
		[FieldOffset(Offset = "0x80")]
		private List<UIRoomPlayerItemController> m_PlayerCtrls;

		// Token: 0x04009F2A RID: 40746
		[Token(Token = "0x4009F2A")]
		[FieldOffset(Offset = "0x88")]
		private int m_Index;
	}
}
