using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002468 RID: 9320
	[Token(Token = "0x2002468")]
	public class UIOperationSettingView : UIBaseView
	{
		// Token: 0x0600C3E0 RID: 50144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3E0")]
		[Address(RVA = "0x16E1474", Offset = "0x16E1474", VA = "0x7BBBEE1474", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C3E1 RID: 50145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3E1")]
		[Address(RVA = "0x16E1A04", Offset = "0x16E1A04", VA = "0x7BBBEE1A04")]
		public UIOperationSettingView()
		{
		}

		// Token: 0x0400E995 RID: 59797
		[Token(Token = "0x400E995")]
		[FieldOffset(Offset = "0x20")]
		public UITable OperationSettingTable;

		// Token: 0x0400E996 RID: 59798
		[Token(Token = "0x400E996")]
		[FieldOffset(Offset = "0x28")]
		public GameObject AutoSliding;

		// Token: 0x0400E997 RID: 59799
		[Token(Token = "0x400E997")]
		[FieldOffset(Offset = "0x30")]
		public GameObject PCBloodTrigger;

		// Token: 0x0400E998 RID: 59800
		[Token(Token = "0x400E998")]
		[FieldOffset(Offset = "0x38")]
		public UIToggle OnToggleATK;

		// Token: 0x0400E999 RID: 59801
		[Token(Token = "0x400E999")]
		[FieldOffset(Offset = "0x40")]
		public UIToggle OffToggleATK;

		// Token: 0x0400E99A RID: 59802
		[Token(Token = "0x400E99A")]
		[FieldOffset(Offset = "0x48")]
		public UIToggle OffToggleZONE;

		// Token: 0x0400E99B RID: 59803
		[Token(Token = "0x400E99B")]
		[FieldOffset(Offset = "0x50")]
		public UIToggle OnToggleZONE;

		// Token: 0x0400E99C RID: 59804
		[Token(Token = "0x400E99C")]
		[FieldOffset(Offset = "0x58")]
		public GameObject AutoPickup;

		// Token: 0x0400E99D RID: 59805
		[Token(Token = "0x400E99D")]
		[FieldOffset(Offset = "0x60")]
		public UISettingToggleGroup IngameTipsToggleGroup;

		// Token: 0x0400E99E RID: 59806
		[Token(Token = "0x400E99E")]
		[FieldOffset(Offset = "0x68")]
		public GameObject DamageSetting;

		// Token: 0x0400E99F RID: 59807
		[Token(Token = "0x400E99F")]
		[FieldOffset(Offset = "0x70")]
		public UIToggle DamageOn;

		// Token: 0x0400E9A0 RID: 59808
		[Token(Token = "0x400E9A0")]
		[FieldOffset(Offset = "0x78")]
		public UIToggle DamageOff;

		// Token: 0x0400E9A1 RID: 59809
		[Token(Token = "0x400E9A1")]
		[FieldOffset(Offset = "0x80")]
		public GameObject AutoSwitchWeapon;

		// Token: 0x0400E9A2 RID: 59810
		[Token(Token = "0x400E9A2")]
		[FieldOffset(Offset = "0x88")]
		public UIToggle SwitchWeaponOn;

		// Token: 0x0400E9A3 RID: 59811
		[Token(Token = "0x400E9A3")]
		[FieldOffset(Offset = "0x90")]
		public UIToggle SwitchWeaponOff;

		// Token: 0x0400E9A4 RID: 59812
		[Token(Token = "0x400E9A4")]
		[FieldOffset(Offset = "0x98")]
		public GameObject UseAuxAim;

		// Token: 0x0400E9A5 RID: 59813
		[Token(Token = "0x400E9A5")]
		[FieldOffset(Offset = "0xA0")]
		public UIToggleButtonGroup HitHint;

		// Token: 0x0400E9A6 RID: 59814
		[Token(Token = "0x400E9A6")]
		[FieldOffset(Offset = "0xA8")]
		public UIToggleButton HitHintEnhanced;

		// Token: 0x0400E9A7 RID: 59815
		[Token(Token = "0x400E9A7")]
		[FieldOffset(Offset = "0xB0")]
		public UIToggleButton HitHintClassic;

		// Token: 0x0400E9A8 RID: 59816
		[Token(Token = "0x400E9A8")]
		[FieldOffset(Offset = "0xB8")]
		public UIToggleButtonGroup NameAlphaGroup;

		// Token: 0x0400E9A9 RID: 59817
		[Token(Token = "0x400E9A9")]
		[FieldOffset(Offset = "0xC0")]
		public UIToggleButton NameAlpha;

		// Token: 0x0400E9AA RID: 59818
		[Token(Token = "0x400E9AA")]
		[FieldOffset(Offset = "0xC8")]
		public UIToggleButton NameClassic;

		// Token: 0x0400E9AB RID: 59819
		[Token(Token = "0x400E9AB")]
		[FieldOffset(Offset = "0xD0")]
		public UIButton CustomizeButton;
	}
}
