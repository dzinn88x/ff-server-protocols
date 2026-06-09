using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200159D RID: 5533
	[Token(Token = "0x200159D")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EEDE4", Offset = "0x10EEDE4")]
	public class UIMallGiftReceiverCallsignController : UIEasyListItemController
	{
		// Token: 0x06006122 RID: 24866 RVA: 0x0001C020 File Offset: 0x0001A220
		[Token(Token = "0x6006122")]
		[Address(RVA = "0x1C732A0", Offset = "0x1C732A0", VA = "0x7BBC4732A0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006123 RID: 24867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006123")]
		[Address(RVA = "0x1C732F0", Offset = "0x1C732F0", VA = "0x7BBC4732F0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006124 RID: 24868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006124")]
		[Address(RVA = "0x1C73354", Offset = "0x1C73354", VA = "0x7BBC473354", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06006125 RID: 24869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006125")]
		[Address(RVA = "0x1C6F8B0", Offset = "0x1C6F8B0", VA = "0x7BBC46F8B0")]
		public void RefreshData(FriendInfo data)
		{
		}

		// Token: 0x06006126 RID: 24870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006126")]
		[Address(RVA = "0x1C7342C", Offset = "0x1C7342C", VA = "0x7BBC47342C")]
		public void UpdateBanner(uint bannerId)
		{
		}

		// Token: 0x06006127 RID: 24871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006127")]
		[Address(RVA = "0x1C73554", Offset = "0x1C73554", VA = "0x7BBC473554")]
		public void UpdateBanner(ResourceID resId)
		{
		}

		// Token: 0x06006128 RID: 24872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006128")]
		[Address(RVA = "0x1C73704", Offset = "0x1C73704", VA = "0x7BBC473704")]
		public UIMallGiftReceiverCallsignController()
		{
		}

		// Token: 0x04008100 RID: 33024
		[Token(Token = "0x4008100")]
		[FieldOffset(Offset = "0x70")]
		private UIMallGiftReceiverCallsignView m_View;
	}
}
