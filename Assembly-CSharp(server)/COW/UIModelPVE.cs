using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001FBD RID: 8125
	[Token(Token = "0x2001FBD")]
	public class UIModelPVE : UIBaseModel
	{
		// Token: 0x0600B43E RID: 46142 RVA: 0x00033198 File Offset: 0x00031398
		[Token(Token = "0x600B43E")]
		[Address(RVA = "0x24273DC", Offset = "0x24273DC", VA = "0x7BBCC273DC", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600B43F RID: 46143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B43F")]
		[Address(RVA = "0x24273E4", Offset = "0x24273E4", VA = "0x7BBCC273E4", Slot = "8")]
		public override void Login(params object[] data)
		{
		}

		// Token: 0x0600B440 RID: 46144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B440")]
		[Address(RVA = "0x24273EC", Offset = "0x24273EC", VA = "0x7BBCC273EC", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600B441 RID: 46145 RVA: 0x000331B0 File Offset: 0x000313B0
		[Token(Token = "0x600B441")]
		[Address(RVA = "0x24274A4", Offset = "0x24274A4", VA = "0x7BBCC274A4")]
		public uint PrimaryWeapon()
		{
			return 0U;
		}

		// Token: 0x0600B442 RID: 46146 RVA: 0x000331C8 File Offset: 0x000313C8
		[Token(Token = "0x600B442")]
		[Address(RVA = "0x2427824", Offset = "0x2427824", VA = "0x7BBCC27824")]
		public uint AvatarDefaultWeapon(uint avatarId)
		{
			return 0U;
		}

		// Token: 0x0600B443 RID: 46147 RVA: 0x000331E0 File Offset: 0x000313E0
		[Token(Token = "0x600B443")]
		[Address(RVA = "0x2427944", Offset = "0x2427944", VA = "0x7BBCC27944")]
		public uint CurrentAvatarDefaultWeapon()
		{
			return 0U;
		}

		// Token: 0x0600B444 RID: 46148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B444")]
		[Address(RVA = "0x2427600", Offset = "0x2427600", VA = "0x7BBCC27600")]
		public void ChoosePVEPrimaryWeapon(uint weapon, ulong groupid = 0UL, bool showTips = true, uint httpOption = 0U)
		{
		}

		// Token: 0x0600B445 RID: 46149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B445")]
		[Address(RVA = "0x24279F4", Offset = "0x24279F4", VA = "0x7BBCC279F4")]
		public uint[] AllPVEWeapons()
		{
			return null;
		}

		// Token: 0x0600B446 RID: 46150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B446")]
		[Address(RVA = "0x2427A74", Offset = "0x2427A74", VA = "0x7BBCC27A74")]
		public void UpdateWeapon(uint weaponID)
		{
		}

		// Token: 0x0600B447 RID: 46151 RVA: 0x000331F8 File Offset: 0x000313F8
		[Token(Token = "0x600B447")]
		[Address(RVA = "0x2427D0C", Offset = "0x2427D0C", VA = "0x7BBCC27D0C")]
		public bool WeaponIsUnlock(uint weaponID)
		{
			return default(bool);
		}

		// Token: 0x0600B448 RID: 46152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B448")]
		[Address(RVA = "0x2427E18", Offset = "0x2427E18", VA = "0x7BBCC27E18")]
		public CSSharedAvatarData AvatarAssociatedWithDefaultWeapon(uint weaponID)
		{
			return null;
		}

		// Token: 0x0600B449 RID: 46153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B449")]
		[Address(RVA = "0x2427EA0", Offset = "0x2427EA0", VA = "0x7BBCC27EA0")]
		public List<MapOpeningInfo> AllOpeningPVEMap()
		{
			return null;
		}

		// Token: 0x0600B44A RID: 46154 RVA: 0x00033210 File Offset: 0x00031410
		[Token(Token = "0x600B44A")]
		[Address(RVA = "0x2427FFC", Offset = "0x2427FFC", VA = "0x7BBCC27FFC")]
		public static bool IsPVEMode(uint gameMode)
		{
			return default(bool);
		}

		// Token: 0x0600B44B RID: 46155 RVA: 0x00033228 File Offset: 0x00031428
		[Token(Token = "0x600B44B")]
		[Address(RVA = "0x2428008", Offset = "0x2428008", VA = "0x7BBCC28008")]
		public bool HasPVEGameOpening()
		{
			return default(bool);
		}

		// Token: 0x0600B44C RID: 46156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B44C")]
		[Address(RVA = "0x2428070", Offset = "0x2428070", VA = "0x7BBCC28070")]
		public UIModelPVE()
		{
		}

		// Token: 0x0600B44D RID: 46157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B44D")]
		[Address(RVA = "0x24280D8", Offset = "0x24280D8", VA = "0x7BBCC280D8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146DBC", Offset = "0x1146DBC")]
		private void <UpdateWeapon>b__11_0()
		{
		}

		// Token: 0x0400B6CF RID: 46799
		[Token(Token = "0x400B6CF")]
		[FieldOffset(Offset = "0x18")]
		private uint m_PVEPrimaryWeaponSkin;

		// Token: 0x0400B6D0 RID: 46800
		[Token(Token = "0x400B6D0")]
		[FieldOffset(Offset = "0x1C")]
		private uint m_SyncExpiredWeapon;

		// Token: 0x0400B6D1 RID: 46801
		[Token(Token = "0x400B6D1")]
		public const uint PropID_PrimaryWeapon_Updated = 2U;

		// Token: 0x02001FBE RID: 8126
		[Token(Token = "0x2001FBE")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD554", Offset = "0x10FD554")]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x0600B44E RID: 46158 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B44E")]
			[Address(RVA = "0x24279EC", Offset = "0x24279EC", VA = "0x7BBCC279EC")]
			public <>c__DisplayClass9_0()
			{
			}

			// Token: 0x0600B44F RID: 46159 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B44F")]
			[Address(RVA = "0x2428258", Offset = "0x2428258", VA = "0x7BBCC28258")]
			internal void <ChoosePVEPrimaryWeapon>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B6D2 RID: 46802
			[Token(Token = "0x400B6D2")]
			[FieldOffset(Offset = "0x10")]
			public UIModelPVE <>4__this;

			// Token: 0x0400B6D3 RID: 46803
			[Token(Token = "0x400B6D3")]
			[FieldOffset(Offset = "0x18")]
			public bool showTips;

			// Token: 0x0400B6D4 RID: 46804
			[Token(Token = "0x400B6D4")]
			[FieldOffset(Offset = "0x1C")]
			public uint weapon;
		}

		// Token: 0x02001FBF RID: 8127
		[Token(Token = "0x2001FBF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD564", Offset = "0x10FD564")]
		private sealed class <>c__DisplayClass14_0
		{
			// Token: 0x0600B450 RID: 46160 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B450")]
			[Address(RVA = "0x2427FF4", Offset = "0x2427FF4", VA = "0x7BBCC27FF4")]
			public <>c__DisplayClass14_0()
			{
			}

			// Token: 0x0600B451 RID: 46161 RVA: 0x00033240 File Offset: 0x00031440
			[Token(Token = "0x600B451")]
			[Address(RVA = "0x24281D8", Offset = "0x24281D8", VA = "0x7BBCC281D8")]
			internal bool <AllOpeningPVEMap>b__0(MapOpeningInfo e)
			{
				return default(bool);
			}

			// Token: 0x0400B6D5 RID: 46805
			[Token(Token = "0x400B6D5")]
			[FieldOffset(Offset = "0x10")]
			public UIModelMapOpeningInfo modelMapOpenInfo;
		}
	}
}
