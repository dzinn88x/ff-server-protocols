using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020018F4 RID: 6388
	[Token(Token = "0x20018F4")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F544C", Offset = "0x10F544C")]
	internal class UIHudItemMarkShowItemController : UIBaseController
	{
		// Token: 0x06008028 RID: 32808 RVA: 0x00022F68 File Offset: 0x00021168
		[Token(Token = "0x6008028")]
		[Address(RVA = "0x1C4A6D8", Offset = "0x1C4A6D8", VA = "0x7BBC44A6D8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008029 RID: 32809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008029")]
		[Address(RVA = "0x1C4A728", Offset = "0x1C4A728", VA = "0x7BBC44A728", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600802A RID: 32810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600802A")]
		[Address(RVA = "0x1C49884", Offset = "0x1C49884", VA = "0x7BBC449884")]
		public void RefreshItemInfo(uint dataID, uint Count, Vector3 Position, byte ContainerType)
		{
		}

		// Token: 0x0600802B RID: 32811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600802B")]
		[Address(RVA = "0x1C4A80C", Offset = "0x1C4A80C", VA = "0x7BBC44A80C")]
		private void OnClickItemMark()
		{
		}

		// Token: 0x0600802C RID: 32812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600802C")]
		[Address(RVA = "0x1C4A9AC", Offset = "0x1C4A9AC", VA = "0x7BBC44A9AC")]
		public UIHudItemMarkShowItemController()
		{
		}

		// Token: 0x04009285 RID: 37509
		[Token(Token = "0x4009285")]
		[FieldOffset(Offset = "0x58")]
		private UIHudItemMarkShowItemView m_View;

		// Token: 0x04009286 RID: 37510
		[Token(Token = "0x4009286")]
		[FieldOffset(Offset = "0x60")]
		private uint ItemID;

		// Token: 0x04009287 RID: 37511
		[Token(Token = "0x4009287")]
		[FieldOffset(Offset = "0x64")]
		private Vector3 ItemPosition;
	}
}
