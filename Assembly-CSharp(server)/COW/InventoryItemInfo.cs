using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001ED1 RID: 7889
	[Token(Token = "0x2001ED1")]
	public class InventoryItemInfo : BaseItemInfo, IComparable<InventoryItemInfo>
	{
		// Token: 0x0600AD24 RID: 44324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD24")]
		[Address(RVA = "0x13F2CC4", Offset = "0x13F2CC4", VA = "0x7BBBBF2CC4")]
		public InventoryItemInfo(Item it)
		{
		}

		// Token: 0x0600AD25 RID: 44325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AD25")]
		[Address(RVA = "0x13F3B88", Offset = "0x13F3B88", VA = "0x7BBBBF3B88")]
		public new static implicit operator InventoryItemInfo(Item it)
		{
			return null;
		}

		// Token: 0x0600AD26 RID: 44326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AD26")]
		[Address(RVA = "0x13F3BE8", Offset = "0x13F3BE8", VA = "0x7BBBBF3BE8")]
		public static implicit operator CSVBaseData(InventoryItemInfo info)
		{
			return null;
		}

		// Token: 0x0600AD27 RID: 44327 RVA: 0x0002FDD8 File Offset: 0x0002DFD8
		[Token(Token = "0x600AD27")]
		[Address(RVA = "0x13F3C10", Offset = "0x13F3C10", VA = "0x7BBBBF3C10", Slot = "4")]
		public int CompareTo(InventoryItemInfo other)
		{
			return 0;
		}

		// Token: 0x0600AD28 RID: 44328 RVA: 0x0002FDF0 File Offset: 0x0002DFF0
		[Token(Token = "0x600AD28")]
		[Address(RVA = "0x13F3DD0", Offset = "0x13F3DD0", VA = "0x7BBBBF3DD0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114646C", Offset = "0x114646C")]
		private bool <.ctor>b__4_0(InventoryItemInfo a)
		{
			return default(bool);
		}

		// Token: 0x0400B186 RID: 45446
		[Token(Token = "0x400B186")]
		[FieldOffset(Offset = "0x48")]
		public CSSharedItemData itemData;

		// Token: 0x0400B187 RID: 45447
		[Token(Token = "0x400B187")]
		[FieldOffset(Offset = "0x50")]
		public Item protoItem;

		// Token: 0x0400B188 RID: 45448
		[Token(Token = "0x400B188")]
		[FieldOffset(Offset = "0x58")]
		public bool IsNewOwned;

		// Token: 0x0400B189 RID: 45449
		[Token(Token = "0x400B189")]
		[FieldOffset(Offset = "0x5C")]
		public uint iID;
	}
}
