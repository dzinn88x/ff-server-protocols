using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001A58 RID: 6744
	[Token(Token = "0x2001A58")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F7FD4", Offset = "0x10F7FD4")]
	public class UIManualMapSupplyItemController : UIBaseController, ITipsDelegate
	{
		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x06008DE5 RID: 36325 RVA: 0x00025D40 File Offset: 0x00023F40
		// (set) Token: 0x06008DE6 RID: 36326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009E4")]
		public bool IsUnlock
		{
			[Token(Token = "0x6008DE5")]
			[Address(RVA = "0x18E6998", Offset = "0x18E6998", VA = "0x7BBC0E6998")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11445B0", Offset = "0x11445B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6008DE6")]
			[Address(RVA = "0x18E6298", Offset = "0x18E6298", VA = "0x7BBC0E6298")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11445C0", Offset = "0x11445C0")]
			set
			{
			}
		}

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x06008DE7 RID: 36327 RVA: 0x00025D58 File Offset: 0x00023F58
		// (set) Token: 0x06008DE8 RID: 36328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009E5")]
		public bool IsSelected
		{
			[Token(Token = "0x6008DE7")]
			[Address(RVA = "0x18E69A0", Offset = "0x18E69A0", VA = "0x7BBC0E69A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11445D0", Offset = "0x11445D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6008DE8")]
			[Address(RVA = "0x18E5DFC", Offset = "0x18E5DFC", VA = "0x7BBC0E5DFC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11445E0", Offset = "0x11445E0")]
			set
			{
			}
		}

		// Token: 0x06008DE9 RID: 36329 RVA: 0x00025D70 File Offset: 0x00023F70
		[Token(Token = "0x6008DE9")]
		[Address(RVA = "0x18E69A8", Offset = "0x18E69A8", VA = "0x7BBC0E69A8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008DEA RID: 36330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DEA")]
		[Address(RVA = "0x18E69F8", Offset = "0x18E69F8", VA = "0x7BBC0E69F8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008DEB RID: 36331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DEB")]
		[Address(RVA = "0x18E6B2C", Offset = "0x18E6B2C", VA = "0x7BBC0E6B2C", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06008DEC RID: 36332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DEC")]
		[Address(RVA = "0x18E6B34", Offset = "0x18E6B34", VA = "0x7BBC0E6B34", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008DED RID: 36333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DED")]
		[Address(RVA = "0x18E6290", Offset = "0x18E6290", VA = "0x7BBC0E6290")]
		public void SetData(ManualInMapData data)
		{
		}

		// Token: 0x06008DEE RID: 36334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DEE")]
		[Address(RVA = "0x18E597C", Offset = "0x18E597C", VA = "0x7BBC0E597C")]
		public void RefreshView()
		{
		}

		// Token: 0x06008DEF RID: 36335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DEF")]
		[Address(RVA = "0x18E62A4", Offset = "0x18E62A4", VA = "0x7BBC0E62A4")]
		public void OnButtonClick()
		{
		}

		// Token: 0x06008DF0 RID: 36336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DF0")]
		[Address(RVA = "0x18E6BCC", Offset = "0x18E6BCC", VA = "0x7BBC0E6BCC", Slot = "28")]
		public void OnTipsDataChange(ETipsType type, int num)
		{
		}

		// Token: 0x06008DF1 RID: 36337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DF1")]
		[Address(RVA = "0x18E6CE0", Offset = "0x18E6CE0", VA = "0x7BBC0E6CE0")]
		public UIManualMapSupplyItemController()
		{
		}

		// Token: 0x040099B5 RID: 39349
		[Token(Token = "0x40099B5")]
		[FieldOffset(Offset = "0x58")]
		private UIManualMapSupplyItemView m_View;

		// Token: 0x040099B6 RID: 39350
		[Token(Token = "0x40099B6")]
		[FieldOffset(Offset = "0x60")]
		private ManualInMapData m_Data;

		// Token: 0x040099B7 RID: 39351
		[Token(Token = "0x40099B7")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112F9EC", Offset = "0x112F9EC")]
		private bool <IsUnlock>k__BackingField;

		// Token: 0x040099B8 RID: 39352
		[Token(Token = "0x40099B8")]
		[FieldOffset(Offset = "0x69")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112F9FC", Offset = "0x112F9FC")]
		private bool <IsSelected>k__BackingField;
	}
}
