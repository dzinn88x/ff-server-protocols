using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200142B RID: 5163
	[Token(Token = "0x200142B")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EC900", Offset = "0x10EC900")]
	internal class UIHudArmsRaceWeaponInfoController : UIHudWeaponInfoController
	{
		// Token: 0x06005563 RID: 21859 RVA: 0x00019728 File Offset: 0x00017928
		[Token(Token = "0x6005563")]
		[Address(RVA = "0x1887928", Offset = "0x1887928", VA = "0x7BBC087928")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005564 RID: 21860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005564")]
		[Address(RVA = "0x1887978", Offset = "0x1887978", VA = "0x7BBC087978", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005565 RID: 21861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005565")]
		[Address(RVA = "0x1887BBC", Offset = "0x1887BBC", VA = "0x7BBC087BBC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005566 RID: 21862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005566")]
		[Address(RVA = "0x1887AA0", Offset = "0x1887AA0", VA = "0x7BBC087AA0")]
		private void InitNextWeapons()
		{
		}

		// Token: 0x06005567 RID: 21863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005567")]
		[Address(RVA = "0x1887CDC", Offset = "0x1887CDC", VA = "0x7BBC087CDC")]
		private void OnGameArmsListCome(params object[] param)
		{
		}

		// Token: 0x06005568 RID: 21864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005568")]
		[Address(RVA = "0x1887EC8", Offset = "0x1887EC8", VA = "0x7BBC087EC8")]
		private void OnPlayerARMLevelUpdate(params object[] param)
		{
		}

		// Token: 0x06005569 RID: 21865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005569")]
		[Address(RVA = "0x1887CF4", Offset = "0x1887CF4", VA = "0x7BBC087CF4")]
		private void UpdateNextWeapons()
		{
		}

		// Token: 0x0600556A RID: 21866 RVA: 0x00019740 File Offset: 0x00017940
		[Token(Token = "0x600556A")]
		[Address(RVA = "0x1887F5C", Offset = "0x1887F5C", VA = "0x7BBC087F5C", Slot = "30")]
		protected override bool IsCheckSilderWeapon()
		{
			return default(bool);
		}

		// Token: 0x0600556B RID: 21867 RVA: 0x00019758 File Offset: 0x00017958
		[Token(Token = "0x600556B")]
		[Address(RVA = "0x1887F64", Offset = "0x1887F64", VA = "0x7BBC087F64", Slot = "31")]
		protected override bool IsCheckHeaveyWeapon()
		{
			return default(bool);
		}

		// Token: 0x0600556C RID: 21868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600556C")]
		[Address(RVA = "0x1887F6C", Offset = "0x1887F6C", VA = "0x7BBC087F6C")]
		public UIHudArmsRaceWeaponInfoController()
		{
		}

		// Token: 0x04007A50 RID: 31312
		[Token(Token = "0x4007A50")]
		private const int NextWeaponsCount = 3;

		// Token: 0x04007A51 RID: 31313
		[Token(Token = "0x4007A51")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_IsInitedNextWeapons;

		// Token: 0x04007A52 RID: 31314
		[Token(Token = "0x4007A52")]
		[FieldOffset(Offset = "0xCC")]
		private int m_CurLevel;

		// Token: 0x04007A53 RID: 31315
		[Token(Token = "0x4007A53")]
		[FieldOffset(Offset = "0xD0")]
		private List<UIHUDArmsRaceNextWeaponsController> m_NextWeaponControllers;
	}
}
