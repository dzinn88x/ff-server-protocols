using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001A80 RID: 6784
	[Token(Token = "0x2001A80")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F855C", Offset = "0x10F855C")]
	public class UINationalFlagItemController : UIEasyListItemController
	{
		// Token: 0x06008EF0 RID: 36592 RVA: 0x000261C0 File Offset: 0x000243C0
		[Token(Token = "0x6008EF0")]
		[Address(RVA = "0x14D76B0", Offset = "0x14D76B0", VA = "0x7BBBCD76B0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008EF1 RID: 36593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EF1")]
		[Address(RVA = "0x14D7700", Offset = "0x14D7700", VA = "0x7BBBCD7700", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008EF2 RID: 36594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EF2")]
		[Address(RVA = "0x14D77E4", Offset = "0x14D77E4", VA = "0x7BBBCD77E4", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06008EF3 RID: 36595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EF3")]
		[Address(RVA = "0x14D7908", Offset = "0x14D7908", VA = "0x7BBBCD7908")]
		private void SelectFlag()
		{
		}

		// Token: 0x06008EF4 RID: 36596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EF4")]
		[Address(RVA = "0x14D7A1C", Offset = "0x14D7A1C", VA = "0x7BBBCD7A1C")]
		public UINationalFlagItemController()
		{
		}

		// Token: 0x04009A6F RID: 39535
		[Token(Token = "0x4009A6F")]
		[FieldOffset(Offset = "0x70")]
		private UINationalFlagItemView m_View;

		// Token: 0x04009A70 RID: 39536
		[Token(Token = "0x4009A70")]
		[FieldOffset(Offset = "0x78")]
		private NationFlagData m_FlagInfo;
	}
}
