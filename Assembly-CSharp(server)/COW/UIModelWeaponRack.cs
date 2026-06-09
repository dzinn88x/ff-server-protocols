using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x0200202C RID: 8236
	[Token(Token = "0x200202C")]
	public class UIModelWeaponRack : UIBaseModel
	{
		// Token: 0x17000CB4 RID: 3252
		// (get) Token: 0x0600B7A4 RID: 47012 RVA: 0x000347B8 File Offset: 0x000329B8
		// (set) Token: 0x0600B7A5 RID: 47013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CB4")]
		public bool GetDataAfterLogin
		{
			[Token(Token = "0x600B7A4")]
			[Address(RVA = "0x14C1B6C", Offset = "0x14C1B6C", VA = "0x7BBBCC1B6C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11478CC", Offset = "0x11478CC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600B7A5")]
			[Address(RVA = "0x14C1B74", Offset = "0x14C1B74", VA = "0x7BBBCC1B74")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11478DC", Offset = "0x11478DC")]
			private set
			{
			}
		}

		// Token: 0x0600B7A6 RID: 47014 RVA: 0x000347D0 File Offset: 0x000329D0
		[Token(Token = "0x600B7A6")]
		[Address(RVA = "0x14C1B80", Offset = "0x14C1B80", VA = "0x7BBBCC1B80", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600B7A7 RID: 47015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7A7")]
		[Address(RVA = "0x14C1B88", Offset = "0x14C1B88", VA = "0x7BBBCC1B88", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600B7A8 RID: 47016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7A8")]
		[Address(RVA = "0x14C1C28", Offset = "0x14C1C28", VA = "0x7BBBCC1C28")]
		public void AddWeapon(uint slot, uint weapon_id)
		{
		}

		// Token: 0x0600B7A9 RID: 47017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7A9")]
		[Address(RVA = "0x14C1D50", Offset = "0x14C1D50", VA = "0x7BBBCC1D50")]
		public void DelWeapon(uint slot, uint weapon_id)
		{
		}

		// Token: 0x0600B7AA RID: 47018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7AA")]
		[Address(RVA = "0x14C1DEC", Offset = "0x14C1DEC", VA = "0x7BBBCC1DEC")]
		public void ProcessDesc(WeaponRackRes res)
		{
		}

		// Token: 0x0600B7AB RID: 47019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7AB")]
		[Address(RVA = "0x14C1F24", Offset = "0x14C1F24", VA = "0x7BBBCC1F24")]
		public UIModelWeaponRack()
		{
		}

		// Token: 0x0400B9AE RID: 47534
		[Token(Token = "0x400B9AE")]
		[FieldOffset(Offset = "0x18")]
		public List<uint> EquipedWeapponIds;

		// Token: 0x0400B9AF RID: 47535
		[Token(Token = "0x400B9AF")]
		[FieldOffset(Offset = "0x20")]
		public List<uint> LastEquipedWeaponIds;

		// Token: 0x0400B9B0 RID: 47536
		[Token(Token = "0x400B9B0")]
		public const uint PropID_Add_Success = 2U;

		// Token: 0x0400B9B1 RID: 47537
		[Token(Token = "0x400B9B1")]
		public const uint PropID_Del_Success = 4U;

		// Token: 0x0400B9B2 RID: 47538
		[Token(Token = "0x400B9B2")]
		public const int SLOTCOUNT = 3;

		// Token: 0x0400B9B3 RID: 47539
		[Token(Token = "0x400B9B3")]
		public const string HDWEAPONRACKGUIDE = "HDWEAPONRACKGUIDE_";

		// Token: 0x0400B9B4 RID: 47540
		[Token(Token = "0x400B9B4")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113085C", Offset = "0x113085C")]
		private bool <GetDataAfterLogin>k__BackingField;
	}
}
