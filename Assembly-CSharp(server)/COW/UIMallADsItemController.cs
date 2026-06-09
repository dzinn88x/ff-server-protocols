using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001582 RID: 5506
	[Token(Token = "0x2001582")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EEB6C", Offset = "0x10EEB6C")]
	public class UIMallADsItemController : UIBaseController
	{
		// Token: 0x06005FFA RID: 24570 RVA: 0x0001BBA0 File Offset: 0x00019DA0
		[Token(Token = "0x6005FFA")]
		[Address(RVA = "0x1CE7510", Offset = "0x1CE7510", VA = "0x7BBC4E7510")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005FFB RID: 24571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FFB")]
		[Address(RVA = "0x1CE7560", Offset = "0x1CE7560", VA = "0x7BBC4E7560", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005FFC RID: 24572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FFC")]
		[Address(RVA = "0x1CE76BC", Offset = "0x1CE76BC", VA = "0x7BBC4E76BC")]
		private void OnItemSelect()
		{
		}

		// Token: 0x06005FFD RID: 24573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FFD")]
		[Address(RVA = "0x1CE7A9C", Offset = "0x1CE7A9C", VA = "0x7BBC4E7A9C")]
		private void SendBannerClickLog(uint id)
		{
		}

		// Token: 0x06005FFE RID: 24574 RVA: 0x0001BBB8 File Offset: 0x00019DB8
		[Token(Token = "0x6005FFE")]
		[Address(RVA = "0x1CE7A04", Offset = "0x1CE7A04", VA = "0x7BBC4E7A04")]
		private uint GetMainType(uint gotoPos)
		{
			return 0U;
		}

		// Token: 0x06005FFF RID: 24575 RVA: 0x0001BBD0 File Offset: 0x00019DD0
		[Token(Token = "0x6005FFF")]
		[Address(RVA = "0x1CE7A20", Offset = "0x1CE7A20", VA = "0x7BBC4E7A20")]
		private uint GetSubType1(uint gotoPos)
		{
			return 0U;
		}

		// Token: 0x06006000 RID: 24576 RVA: 0x0001BBE8 File Offset: 0x00019DE8
		[Token(Token = "0x6006000")]
		[Address(RVA = "0x1CE7A44", Offset = "0x1CE7A44", VA = "0x7BBC4E7A44")]
		private uint GetSubType2(uint gotoPos)
		{
			return 0U;
		}

		// Token: 0x06006001 RID: 24577 RVA: 0x0001BC00 File Offset: 0x00019E00
		[Token(Token = "0x6006001")]
		[Address(RVA = "0x1CE7A70", Offset = "0x1CE7A70", VA = "0x7BBC4E7A70")]
		private uint GetSubType3(uint gotoPos)
		{
			return 0U;
		}

		// Token: 0x06006002 RID: 24578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006002")]
		[Address(RVA = "0x1CE7C10", Offset = "0x1CE7C10", VA = "0x7BBC4E7C10")]
		public void RefreshAdData(AdItemInfo info)
		{
		}

		// Token: 0x06006003 RID: 24579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006003")]
		[Address(RVA = "0x1CE7DF4", Offset = "0x1CE7DF4", VA = "0x7BBC4E7DF4")]
		public UIMallADsItemController()
		{
		}

		// Token: 0x04008049 RID: 32841
		[Token(Token = "0x4008049")]
		[FieldOffset(Offset = "0x58")]
		private UIMallADsItemView m_View;

		// Token: 0x0400804A RID: 32842
		[Token(Token = "0x400804A")]
		[FieldOffset(Offset = "0x60")]
		private uint m_SystemType;

		// Token: 0x0400804B RID: 32843
		[Token(Token = "0x400804B")]
		[FieldOffset(Offset = "0x64")]
		private uint m_MallItemID;

		// Token: 0x0400804C RID: 32844
		[Token(Token = "0x400804C")]
		[FieldOffset(Offset = "0x68")]
		private AdItemInfo m_Info;
	}
}
