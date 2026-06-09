using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001588 RID: 5512
	[Token(Token = "0x2001588")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EEC6C", Offset = "0x10EEC6C")]
	public class UIMallCrystalItemController : UIMallCDNItemController
	{
		// Token: 0x0600605E RID: 24670 RVA: 0x0001BD50 File Offset: 0x00019F50
		[Token(Token = "0x600605E")]
		[Address(RVA = "0x1C5F4DC", Offset = "0x1C5F4DC", VA = "0x7BBC45F4DC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600605F RID: 24671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600605F")]
		[Address(RVA = "0x1C5F52C", Offset = "0x1C5F52C", VA = "0x7BBC45F52C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006060 RID: 24672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006060")]
		[Address(RVA = "0x1C5F594", Offset = "0x1C5F594", VA = "0x7BBC45F594")]
		private void InitCommonWidget()
		{
		}

		// Token: 0x06006061 RID: 24673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006061")]
		[Address(RVA = "0x1C5F63C", Offset = "0x1C5F63C", VA = "0x7BBC45F63C", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06006062 RID: 24674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006062")]
		[Address(RVA = "0x1C5F738", Offset = "0x1C5F738", VA = "0x7BBC45F738", Slot = "39")]
		protected override void RefreshItemView()
		{
		}

		// Token: 0x06006063 RID: 24675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006063")]
		[Address(RVA = "0x1C5F870", Offset = "0x1C5F870", VA = "0x7BBC45F870")]
		private void SetExchangeInfo()
		{
		}

		// Token: 0x06006064 RID: 24676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006064")]
		[Address(RVA = "0x1C5FA48", Offset = "0x1C5FA48", VA = "0x7BBC45FA48", Slot = "34")]
		protected override void SendItemClickEvent()
		{
		}

		// Token: 0x06006065 RID: 24677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006065")]
		[Address(RVA = "0x1C5FC04", Offset = "0x1C5FC04", VA = "0x7BBC45FC04", Slot = "35")]
		protected override void SendClothClickEvent()
		{
		}

		// Token: 0x06006066 RID: 24678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006066")]
		[Address(RVA = "0x1C5FDDC", Offset = "0x1C5FDDC", VA = "0x7BBC45FDDC")]
		public UIMallCrystalItemController()
		{
		}

		// Token: 0x0400807D RID: 32893
		[Token(Token = "0x400807D")]
		[FieldOffset(Offset = "0x230")]
		private UIMallCrystalItemView m_View;

		// Token: 0x0400807E RID: 32894
		[Token(Token = "0x400807E")]
		[FieldOffset(Offset = "0x238")]
		private ExchangeStoreItemDesc m_Info;
	}
}
