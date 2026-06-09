using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;
using tcp;

namespace COW
{
	// Token: 0x02001D6E RID: 7534
	[Token(Token = "0x2001D6E")]
	public class UIModelAvatarProfile : UIBaseModel
	{
		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x0600A45D RID: 42077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ADD")]
		public Dictionary<uint, AvatarProfile> AvatarProfileMap
		{
			[Token(Token = "0x600A45D")]
			[Address(RVA = "0x235B5A8", Offset = "0x235B5A8", VA = "0x7BBCB5B5A8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x0600A45E RID: 42078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ADE")]
		public List<uint> AvailableSkills
		{
			[Token(Token = "0x600A45E")]
			[Address(RVA = "0x235B5B0", Offset = "0x235B5B0", VA = "0x7BBCB5B5B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x0600A45F RID: 42079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ADF")]
		public List<AvatarProfileDataOverrided> AvatarProfileDescList
		{
			[Token(Token = "0x600A45F")]
			[Address(RVA = "0x235B5B8", Offset = "0x235B5B8", VA = "0x7BBCB5B5B8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x0600A460 RID: 42080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AE0")]
		public List<AvatarLevelUpCard> LevelUpCardList
		{
			[Token(Token = "0x600A460")]
			[Address(RVA = "0x235B5C0", Offset = "0x235B5C0", VA = "0x7BBCB5B5C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x0600A461 RID: 42081 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A462 RID: 42082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AE1")]
		public AvatarProfile CurrentAvatar
		{
			[Token(Token = "0x600A461")]
			[Address(RVA = "0x235B7F0", Offset = "0x235B7F0", VA = "0x7BBCB5B7F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600A462")]
			[Address(RVA = "0x235B7F8", Offset = "0x235B7F8", VA = "0x7BBCB5B7F8")]
			set
			{
			}
		}

		// Token: 0x0600A463 RID: 42083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A463")]
		[Address(RVA = "0x235B8EC", Offset = "0x235B8EC", VA = "0x7BBCB5B8EC")]
		public void SetAvatarProfile(AvatarProfile data)
		{
		}

		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x0600A464 RID: 42084 RVA: 0x0002BAA0 File Offset: 0x00029CA0
		// (set) Token: 0x0600A465 RID: 42085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AE2")]
		public int UniversalDebrisCnt
		{
			[Token(Token = "0x600A464")]
			[Address(RVA = "0x235B8F4", Offset = "0x235B8F4", VA = "0x7BBCB5B8F4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600A465")]
			[Address(RVA = "0x235B8FC", Offset = "0x235B8FC", VA = "0x7BBCB5B8FC")]
			set
			{
			}
		}

		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x0600A466 RID: 42086 RVA: 0x0002BAB8 File Offset: 0x00029CB8
		// (set) Token: 0x0600A467 RID: 42087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AE3")]
		public bool NewBieAvatarGuide
		{
			[Token(Token = "0x600A466")]
			[Address(RVA = "0x235B904", Offset = "0x235B904", VA = "0x7BBCB5B904")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600A467")]
			[Address(RVA = "0x235B90C", Offset = "0x235B90C", VA = "0x7BBCB5B90C")]
			set
			{
			}
		}

		// Token: 0x0600A468 RID: 42088 RVA: 0x0002BAD0 File Offset: 0x00029CD0
		[Token(Token = "0x600A468")]
		[Address(RVA = "0x235B9B4", Offset = "0x235B9B4", VA = "0x7BBCB5B9B4", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600A469 RID: 42089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A469")]
		[Address(RVA = "0x235B9BC", Offset = "0x235B9BC", VA = "0x7BBCB5B9BC", Slot = "8")]
		public override void Login(params object[] data)
		{
		}

		// Token: 0x0600A46A RID: 42090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A46A")]
		[Address(RVA = "0x235BBC0", Offset = "0x235BBC0", VA = "0x7BBCB5BBC0", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600A46B RID: 42091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A46B")]
		[Address(RVA = "0x235BD50", Offset = "0x235BD50", VA = "0x7BBCB5BD50")]
		private void InitData()
		{
		}

		// Token: 0x0600A46C RID: 42092 RVA: 0x0002BAE8 File Offset: 0x00029CE8
		[Token(Token = "0x600A46C")]
		[Address(RVA = "0x235BFE0", Offset = "0x235BFE0", VA = "0x7BBCB5BFE0")]
		public bool CheckIsHideAvatar(uint avatarid)
		{
			return default(bool);
		}

		// Token: 0x0600A46D RID: 42093 RVA: 0x0002BB00 File Offset: 0x00029D00
		[Token(Token = "0x600A46D")]
		[Address(RVA = "0x235C050", Offset = "0x235C050", VA = "0x7BBCB5C050")]
		public uint GetAvatarIdBySkillId(uint _skillid)
		{
			return 0U;
		}

		// Token: 0x0600A46E RID: 42094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A46E")]
		[Address(RVA = "0x235BF60", Offset = "0x235BF60", VA = "0x7BBCB5BF60")]
		public AvatarProfile GetAvatarProfile(uint avatarID)
		{
			return null;
		}

		// Token: 0x0600A46F RID: 42095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A46F")]
		[Address(RVA = "0x235C24C", Offset = "0x235C24C", VA = "0x7BBCB5C24C")]
		public void LockProfile(uint avatarID)
		{
		}

		// Token: 0x0600A470 RID: 42096 RVA: 0x0002BB18 File Offset: 0x00029D18
		[Token(Token = "0x600A470")]
		[Address(RVA = "0x235C268", Offset = "0x235C268", VA = "0x7BBCB5C268")]
		public int GetOpenSlotCount(uint avatarID)
		{
			return 0;
		}

		// Token: 0x0600A471 RID: 42097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A471")]
		[Address(RVA = "0x235C438", Offset = "0x235C438", VA = "0x7BBCB5C438")]
		public AvatarProfileDataOverrided GetAvatarProfileData(uint _pID)
		{
			return null;
		}

		// Token: 0x0600A472 RID: 42098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A472")]
		[Address(RVA = "0x235C570", Offset = "0x235C570", VA = "0x7BBCB5C570")]
		private void UpdateAvatarInfo(List<AvatarProfile> profiles)
		{
		}

		// Token: 0x0600A473 RID: 42099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A473")]
		[Address(RVA = "0x235D0E4", Offset = "0x235D0E4", VA = "0x7BBCB5D0E4")]
		public void ReadAvatarprofileRedDot(uint avatarID)
		{
		}

		// Token: 0x0600A474 RID: 42100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A474")]
		[Address(RVA = "0x235D23C", Offset = "0x235D23C", VA = "0x7BBCB5D23C")]
		private void UpdateTips()
		{
		}

		// Token: 0x0600A475 RID: 42101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A475")]
		[Address(RVA = "0x235D3B4", Offset = "0x235D3B4", VA = "0x7BBCB5D3B4")]
		private void UpdateSkillInfo(uint[] Skills)
		{
		}

		// Token: 0x0600A476 RID: 42102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A476")]
		[Address(RVA = "0x235D564", Offset = "0x235D564", VA = "0x7BBCB5D564")]
		private void UpdateSkillInfoById(AvatarProfile profile, uint id)
		{
		}

		// Token: 0x0600A477 RID: 42103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A477")]
		[Address(RVA = "0x235D604", Offset = "0x235D604", VA = "0x7BBCB5D604")]
		public void UpdateDebrisCnt()
		{
		}

		// Token: 0x0600A478 RID: 42104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A478")]
		[Address(RVA = "0x235D6D0", Offset = "0x235D6D0", VA = "0x7BBCB5D6D0")]
		public void UpdateInfoByInventoryItems()
		{
		}

		// Token: 0x0600A479 RID: 42105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A479")]
		[Address(RVA = "0x235DEAC", Offset = "0x235DEAC", VA = "0x7BBCB5DEAC")]
		public void RequestMyAvatarList(uint httpOp = 0U, bool force = true)
		{
		}

		// Token: 0x0600A47A RID: 42106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A47A")]
		[Address(RVA = "0x235E1C0", Offset = "0x235E1C0", VA = "0x7BBCB5E1C0")]
		public void ForceRequestAvatarList()
		{
		}

		// Token: 0x0600A47B RID: 42107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A47B")]
		[Address(RVA = "0x235E364", Offset = "0x235E364", VA = "0x7BBCB5E364")]
		public void RequestSkillList(uint httpOp = 0U)
		{
		}

		// Token: 0x0600A47C RID: 42108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A47C")]
		[Address(RVA = "0x235E4E4", Offset = "0x235E4E4", VA = "0x7BBCB5E4E4")]
		public void RequestLoginGetProfile(uint httpOp = 0U)
		{
		}

		// Token: 0x0600A47D RID: 42109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A47D")]
		[Address(RVA = "0x235E664", Offset = "0x235E664", VA = "0x7BBCB5E664")]
		public void ProcessProfileDesc(CSGetUnlockProfileInfoRes profileRes)
		{
		}

		// Token: 0x0600A47E RID: 42110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A47E")]
		[Address(RVA = "0x235EEA4", Offset = "0x235EEA4", VA = "0x7BBCB5EEA4")]
		public void RequestHideAvatars()
		{
		}

		// Token: 0x0600A47F RID: 42111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A47F")]
		[Address(RVA = "0x235F018", Offset = "0x235F018", VA = "0x7BBCB5F018")]
		public void ProcessHideAvatars(CSGetHideAvatarRes res)
		{
		}

		// Token: 0x0600A480 RID: 42112 RVA: 0x0002BB30 File Offset: 0x00029D30
		[Token(Token = "0x600A480")]
		[Address(RVA = "0x235D628", Offset = "0x235D628", VA = "0x7BBCB5D628")]
		private int GetUniversalDebrisCnt()
		{
			return 0;
		}

		// Token: 0x0600A481 RID: 42113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A481")]
		[Address(RVA = "0x235F0E0", Offset = "0x235F0E0", VA = "0x7BBCB5F0E0")]
		public void ChangeSimpleSelectedAvatar(uint selectedAvatarID)
		{
		}

		// Token: 0x0600A482 RID: 42114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A482")]
		[Address(RVA = "0x235CEA8", Offset = "0x235CEA8", VA = "0x7BBCB5CEA8")]
		public void ChangeSelectedAvatar(uint selectedAvatarID, bool callFromAvatarList = false)
		{
		}

		// Token: 0x0600A483 RID: 42115 RVA: 0x0002BB48 File Offset: 0x00029D48
		[Token(Token = "0x600A483")]
		[Address(RVA = "0x235F2BC", Offset = "0x235F2BC", VA = "0x7BBCB5F2BC")]
		public bool CheckUnlockManually(uint avatarID)
		{
			return default(bool);
		}

		// Token: 0x0600A484 RID: 42116 RVA: 0x0002BB60 File Offset: 0x00029D60
		[Token(Token = "0x600A484")]
		[Address(RVA = "0x235F3B8", Offset = "0x235F3B8", VA = "0x7BBCB5F3B8")]
		public bool IsUnlockLevelLimitSatisfied(uint avatarID)
		{
			return default(bool);
		}

		// Token: 0x0600A485 RID: 42117 RVA: 0x0002BB78 File Offset: 0x00029D78
		[Token(Token = "0x600A485")]
		[Address(RVA = "0x235D1AC", Offset = "0x235D1AC", VA = "0x7BBCB5D1AC")]
		public bool IsUnlockDebrisCountSatisfied(uint avatarID, bool includeUniversal = true)
		{
			return default(bool);
		}

		// Token: 0x0600A486 RID: 42118 RVA: 0x0002BB90 File Offset: 0x00029D90
		[Token(Token = "0x600A486")]
		[Address(RVA = "0x235F4B4", Offset = "0x235F4B4", VA = "0x7BBCB5F4B4")]
		public bool IsUnlockOtherResourceSatisfied(uint avatarID)
		{
			return default(bool);
		}

		// Token: 0x0600A487 RID: 42119 RVA: 0x0002BBA8 File Offset: 0x00029DA8
		[Token(Token = "0x600A487")]
		[Address(RVA = "0x235D2E8", Offset = "0x235D2E8", VA = "0x7BBCB5D2E8")]
		public bool NeedShowProfileCouldLevelupTips(uint avatarID)
		{
			return default(bool);
		}

		// Token: 0x0600A488 RID: 42120 RVA: 0x0002BBC0 File Offset: 0x00029DC0
		[Token(Token = "0x600A488")]
		[Address(RVA = "0x235F560", Offset = "0x235F560", VA = "0x7BBCB5F560")]
		public bool CanUnlockNextProfile(uint avatarID)
		{
			return default(bool);
		}

		// Token: 0x0600A489 RID: 42121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A489")]
		[Address(RVA = "0x235DC48", Offset = "0x235DC48", VA = "0x7BBCB5DC48")]
		public void RequestUnlockAvatarHiddenly(uint avatarID)
		{
		}

		// Token: 0x0600A48A RID: 42122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A48A")]
		[Address(RVA = "0x235F5D4", Offset = "0x235F5D4", VA = "0x7BBCB5F5D4")]
		public void OnUnlockedNewAvatar(AvatarProfile avatar)
		{
		}

		// Token: 0x0600A48B RID: 42123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A48B")]
		[Address(RVA = "0x235F754", Offset = "0x235F754", VA = "0x7BBCB5F754")]
		public void OnUnlockedNewSkill(uint newSkillID)
		{
		}

		// Token: 0x0600A48C RID: 42124 RVA: 0x0002BBD8 File Offset: 0x00029DD8
		[Token(Token = "0x600A48C")]
		[Address(RVA = "0x235FC64", Offset = "0x235FC64", VA = "0x7BBCB5FC64")]
		public bool HasActiveSkillBesidesSlot(uint avatarid, int slot)
		{
			return default(bool);
		}

		// Token: 0x0600A48D RID: 42125 RVA: 0x0002BBF0 File Offset: 0x00029DF0
		[Token(Token = "0x600A48D")]
		[Address(RVA = "0x235FE94", Offset = "0x235FE94", VA = "0x7BBCB5FE94")]
		public uint GetActiveSkillInEquipedSkills()
		{
			return 0U;
		}

		// Token: 0x0600A48E RID: 42126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A48E")]
		[Address(RVA = "0x235FFF8", Offset = "0x235FFF8", VA = "0x7BBCB5FFF8")]
		public void RequestUnlockProfile(uint avatarID, proto.EInventory.CurrencyType currencyType, bool flag = false)
		{
		}

		// Token: 0x0600A48F RID: 42127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A48F")]
		[Address(RVA = "0x2360484", Offset = "0x2360484", VA = "0x7BBCB60484")]
		public void UpdateNewItem(Item[] newInventories)
		{
		}

		// Token: 0x0600A490 RID: 42128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A490")]
		[Address(RVA = "0x23607F8", Offset = "0x23607F8", VA = "0x7BBCB607F8")]
		private void ShowRewardList(Item awardItem, bool showmax = false)
		{
		}

		// Token: 0x0600A491 RID: 42129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A491")]
		[Address(RVA = "0x2360C0C", Offset = "0x2360C0C", VA = "0x7BBCB60C0C")]
		public void RequestUseUpgradeCard(uint avatarID, uint upgradeCardID)
		{
		}

		// Token: 0x0600A492 RID: 42130 RVA: 0x0002BC08 File Offset: 0x00029E08
		[Token(Token = "0x600A492")]
		[Address(RVA = "0x2360EB8", Offset = "0x2360EB8", VA = "0x7BBCB60EB8")]
		public int GetUpgradeCardToLevel(int _cardId)
		{
			return 0;
		}

		// Token: 0x0600A493 RID: 42131 RVA: 0x0002BC20 File Offset: 0x00029E20
		[Token(Token = "0x600A493")]
		[Address(RVA = "0x2360FFC", Offset = "0x2360FFC", VA = "0x7BBCB60FFC")]
		public int GetSkillLevelByUsingLevelCard(int _cardId, int avatarid)
		{
			return 0;
		}

		// Token: 0x0600A494 RID: 42132 RVA: 0x0002BC38 File Offset: 0x00029E38
		[Token(Token = "0x600A494")]
		[Address(RVA = "0x23611F8", Offset = "0x23611F8", VA = "0x7BBCB611F8")]
		public int GetSkillLvByCurrentProfileLv(int profileLv)
		{
			return 0;
		}

		// Token: 0x0600A495 RID: 42133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A495")]
		[Address(RVA = "0x2361268", Offset = "0x2361268", VA = "0x7BBCB61268")]
		public List<AvatarProfileDataOverrided> GetUseUpgradeCardRewardList(int _avatarid, int tolevel)
		{
			return null;
		}

		// Token: 0x0600A496 RID: 42134 RVA: 0x0002BC50 File Offset: 0x00029E50
		[Token(Token = "0x600A496")]
		[Address(RVA = "0x2361444", Offset = "0x2361444", VA = "0x7BBCB61444")]
		public bool HasItemRewardAfterUnlockProfile(uint avatarId, int toProfileLv)
		{
			return default(bool);
		}

		// Token: 0x0600A497 RID: 42135 RVA: 0x0002BC68 File Offset: 0x00029E68
		[Token(Token = "0x600A497")]
		[Address(RVA = "0x23615D8", Offset = "0x23615D8", VA = "0x7BBCB615D8")]
		public uint GetAvatarLevelCardGoPos(uint levelCardId)
		{
			return 0U;
		}

		// Token: 0x0600A498 RID: 42136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A498")]
		[Address(RVA = "0x23616E8", Offset = "0x23616E8", VA = "0x7BBCB616E8")]
		public void ProcessAvatarGoPosDate(CSGetGoPosRes res)
		{
		}

		// Token: 0x0600A499 RID: 42137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A499")]
		[Address(RVA = "0x2361900", Offset = "0x2361900", VA = "0x7BBCB61900")]
		public GoPos GetAvatarOrPetGoPosData(uint avatarID)
		{
			return null;
		}

		// Token: 0x0600A49A RID: 42138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A49A")]
		[Address(RVA = "0x2361B68", Offset = "0x2361B68", VA = "0x7BBCB61B68")]
		public GoPos GetAvatarBundleGoPosData(uint avatarID)
		{
			return null;
		}

		// Token: 0x0600A49B RID: 42139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A49B")]
		[Address(RVA = "0x2361AC4", Offset = "0x2361AC4", VA = "0x7BBCB61AC4")]
		private Predicate<GoPos> FindGoPosByTime(ulong now)
		{
			return null;
		}

		// Token: 0x0600A49C RID: 42140 RVA: 0x0002BC80 File Offset: 0x00029E80
		[Token(Token = "0x600A49C")]
		[Address(RVA = "0x2361F00", Offset = "0x2361F00", VA = "0x7BBCB61F00")]
		private int SortGoPos(GoPos a, GoPos b)
		{
			return 0;
		}

		// Token: 0x0600A49D RID: 42141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A49D")]
		[Address(RVA = "0x2361F88", Offset = "0x2361F88", VA = "0x7BBCB61F88")]
		public void RequestEquipSkill(uint avatarID, int skillID, int slotIndex)
		{
		}

		// Token: 0x0600A49E RID: 42142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A49E")]
		[Address(RVA = "0x2362350", Offset = "0x2362350", VA = "0x7BBCB62350")]
		public void RequestUnLockSkillSlot(uint avatarID, int slotIndex, proto.EInventory.CurrencyType currencyType)
		{
		}

		// Token: 0x0600A49F RID: 42143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A49F")]
		[Address(RVA = "0x2362590", Offset = "0x2362590", VA = "0x7BBCB62590")]
		public void RequestUseUniversalDebris(uint targetDebrisID, int ExchangeUniversaldebrisCnt, uint avatarID)
		{
		}

		// Token: 0x0600A4A0 RID: 42144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4A0")]
		[Address(RVA = "0x23627EC", Offset = "0x23627EC", VA = "0x7BBCB627EC")]
		private void UpdateAvatarFirstSlotSkills(AvatarProfile profileInfo)
		{
		}

		// Token: 0x0600A4A1 RID: 42145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4A1")]
		[Address(RVA = "0x235CAA4", Offset = "0x235CAA4", VA = "0x7BBCB5CAA4")]
		private void UpdateAvatarEquippedSkills(AvatarProfile profileInfo)
		{
		}

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x0600A4A2 RID: 42146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AE4")]
		public List<uint> CacheExpireAvatarLst
		{
			[Token(Token = "0x600A4A2")]
			[Address(RVA = "0x23627F0", Offset = "0x23627F0", VA = "0x7BBCB627F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600A4A3 RID: 42147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4A3")]
		[Address(RVA = "0x23627F8", Offset = "0x23627F8", VA = "0x7BBCB627F8")]
		public void OnLimitAvatarChange(AvatarProfile profileRes, List<Item> rewards)
		{
		}

		// Token: 0x0600A4A4 RID: 42148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4A4")]
		[Address(RVA = "0x2362A84", Offset = "0x2362A84", VA = "0x7BBCB62A84")]
		public void OnLimitAvatarExpire(List<Item> expireItems)
		{
		}

		// Token: 0x0600A4A5 RID: 42149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4A5")]
		[Address(RVA = "0x2362CEC", Offset = "0x2362CEC", VA = "0x7BBCB62CEC")]
		private void ProcessExpireAvatar(AvatarProfile profile)
		{
		}

		// Token: 0x0600A4A6 RID: 42150 RVA: 0x0002BC98 File Offset: 0x00029E98
		[Token(Token = "0x600A4A6")]
		[Address(RVA = "0x2362D54", Offset = "0x2362D54", VA = "0x7BBCB62D54")]
		public bool CheckHasAvatarExpire()
		{
			return default(bool);
		}

		// Token: 0x0600A4A7 RID: 42151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A4A7")]
		[Address(RVA = "0x2362EF4", Offset = "0x2362EF4", VA = "0x7BBCB62EF4")]
		public List<uint> GetExpireAvatarLst()
		{
			return null;
		}

		// Token: 0x0600A4A8 RID: 42152 RVA: 0x0002BCB0 File Offset: 0x00029EB0
		[Token(Token = "0x600A4A8")]
		[Address(RVA = "0x2363160", Offset = "0x2363160", VA = "0x7BBCB63160")]
		public bool IsLimitAvatar(uint avatarId)
		{
			return default(bool);
		}

		// Token: 0x0600A4A9 RID: 42153 RVA: 0x0002BCC8 File Offset: 0x00029EC8
		[Token(Token = "0x600A4A9")]
		[Address(RVA = "0x2363204", Offset = "0x2363204", VA = "0x7BBCB63204")]
		public bool IsAvatarExpire(uint avatarId)
		{
			return default(bool);
		}

		// Token: 0x0600A4AA RID: 42154 RVA: 0x0002BCE0 File Offset: 0x00029EE0
		[Token(Token = "0x600A4AA")]
		[Address(RVA = "0x2360320", Offset = "0x2360320", VA = "0x7BBCB60320")]
		private bool CheckAvatarAvalible(uint avatarId)
		{
			return default(bool);
		}

		// Token: 0x0600A4AB RID: 42155 RVA: 0x0002BCF8 File Offset: 0x00029EF8
		[Token(Token = "0x600A4AB")]
		[Address(RVA = "0x235CC1C", Offset = "0x235CC1C", VA = "0x7BBCB5CC1C")]
		private uint DoSelectOneAvatarShow(List<AvatarProfile> profiles)
		{
			return 0U;
		}

		// Token: 0x0600A4AC RID: 42156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4AC")]
		[Address(RVA = "0x23632EC", Offset = "0x23632EC", VA = "0x7BBCB632EC")]
		public void CheckHasExpireAvatarOnReturnLobby()
		{
		}

		// Token: 0x0600A4AD RID: 42157 RVA: 0x0002BD10 File Offset: 0x00029F10
		[Token(Token = "0x600A4AD")]
		[Address(RVA = "0x235F4F0", Offset = "0x235F4F0", VA = "0x7BBCB5F4F0")]
		public bool IsAwakenAvatar(uint avatarID)
		{
			return default(bool);
		}

		// Token: 0x0600A4AE RID: 42158 RVA: 0x0002BD28 File Offset: 0x00029F28
		[Token(Token = "0x600A4AE")]
		[Address(RVA = "0x2363404", Offset = "0x2363404", VA = "0x7BBCB63404")]
		public bool ShouldShowAwakenEntry(uint avatarID)
		{
			return default(bool);
		}

		// Token: 0x0600A4AF RID: 42159 RVA: 0x0002BD40 File Offset: 0x00029F40
		[Token(Token = "0x600A4AF")]
		[Address(RVA = "0x23634B4", Offset = "0x23634B4", VA = "0x7BBCB634B4")]
		public bool NeedShowSingleInAvatarList(uint avatarID)
		{
			return default(bool);
		}

		// Token: 0x0600A4B0 RID: 42160 RVA: 0x0002BD58 File Offset: 0x00029F58
		[Token(Token = "0x600A4B0")]
		[Address(RVA = "0x2363564", Offset = "0x2363564", VA = "0x7BBCB63564")]
		public uint GetAwakenAvatarId(uint avatarid)
		{
			return 0U;
		}

		// Token: 0x0600A4B1 RID: 42161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4B1")]
		[Address(RVA = "0x2363614", Offset = "0x2363614", VA = "0x7BBCB63614")]
		public void ProcessAvatarAwakenInfo(CSGetAvatarAwakenRes res)
		{
		}

		// Token: 0x0600A4B2 RID: 42162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4B2")]
		[Address(RVA = "0x23639E8", Offset = "0x23639E8", VA = "0x7BBCB639E8")]
		public void RefreshAvatarAwakenState()
		{
		}

		// Token: 0x0600A4B3 RID: 42163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A4B3")]
		[Address(RVA = "0x2363CCC", Offset = "0x2363CCC", VA = "0x7BBCB63CCC")]
		public AvatarSkill GetAwakenSkillByOriAvatarID(uint oriAvatarID)
		{
			return null;
		}

		// Token: 0x0600A4B4 RID: 42164 RVA: 0x0002BD70 File Offset: 0x00029F70
		[Token(Token = "0x600A4B4")]
		[Address(RVA = "0x2363E98", Offset = "0x2363E98", VA = "0x7BBCB63E98")]
		public int GetCanAvatarAwakenNeedLevel(uint oriAvatarID)
		{
			return 0;
		}

		// Token: 0x0600A4B5 RID: 42165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A4B5")]
		[Address(RVA = "0x236405C", Offset = "0x236405C", VA = "0x7BBCB6405C")]
		public AvatarAwaken GetAwakenInfo(uint oriAvatarID)
		{
			return null;
		}

		// Token: 0x0600A4B6 RID: 42166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A4B6")]
		[Address(RVA = "0x2364100", Offset = "0x2364100", VA = "0x7BBCB64100")]
		public AwakenComic GetAwakenComicInfo(uint oriAvatarID, uint comicID)
		{
			return null;
		}

		// Token: 0x0600A4B7 RID: 42167 RVA: 0x0002BD88 File Offset: 0x00029F88
		[Token(Token = "0x600A4B7")]
		[Address(RVA = "0x23641C4", Offset = "0x23641C4", VA = "0x7BBCB641C4")]
		public uint GetCurrentUnlockAwakenComicCount(uint oriAvatarID)
		{
			return 0U;
		}

		// Token: 0x0600A4B8 RID: 42168 RVA: 0x0002BDA0 File Offset: 0x00029FA0
		[Token(Token = "0x600A4B8")]
		[Address(RVA = "0x236437C", Offset = "0x236437C", VA = "0x7BBCB6437C")]
		public uint GetCurrentUnlockAwakenComicFragmentsCnt(uint oriAvatarID)
		{
			return 0U;
		}

		// Token: 0x0600A4B9 RID: 42169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4B9")]
		[Address(RVA = "0x2364530", Offset = "0x2364530", VA = "0x7BBCB64530")]
		public void RequestClaimAvatarAwaken(uint origionalID)
		{
		}

		// Token: 0x0600A4BA RID: 42170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4BA")]
		[Address(RVA = "0x23646C8", Offset = "0x23646C8", VA = "0x7BBCB646C8")]
		public void RequestGetAvatarAwakenComicInfo()
		{
		}

		// Token: 0x0600A4BB RID: 42171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4BB")]
		[Address(RVA = "0x2364844", Offset = "0x2364844", VA = "0x7BBCB64844")]
		private void UpdateAvatarAwakenComic(List<AwakenComic> ComicList)
		{
		}

		// Token: 0x0600A4BC RID: 42172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4BC")]
		[Address(RVA = "0x2364AC0", Offset = "0x2364AC0", VA = "0x7BBCB64AC0")]
		public void RequestRefreshAvatarAwakenTaskInfo(uint origionalID)
		{
		}

		// Token: 0x0600A4BD RID: 42173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4BD")]
		[Address(RVA = "0x2364E40", Offset = "0x2364E40", VA = "0x7BBCB64E40")]
		private void UpdateAvatarAwakenRefreshCount(uint origionalID, uint count)
		{
		}

		// Token: 0x0600A4BE RID: 42174 RVA: 0x0002BDB8 File Offset: 0x00029FB8
		[Token(Token = "0x600A4BE")]
		[Address(RVA = "0x2364EB8", Offset = "0x2364EB8", VA = "0x7BBCB64EB8")]
		public uint GetCurrentRefreshCount(uint origionalID)
		{
			return 0U;
		}

		// Token: 0x0600A4BF RID: 42175 RVA: 0x0002BDD0 File Offset: 0x00029FD0
		[Token(Token = "0x600A4BF")]
		[Address(RVA = "0x2364F68", Offset = "0x2364F68", VA = "0x7BBCB64F68")]
		public uint GetCurrentFinishTaskCount(uint origionalID)
		{
			return 0U;
		}

		// Token: 0x0600A4C0 RID: 42176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4C0")]
		[Address(RVA = "0x2365128", Offset = "0x2365128", VA = "0x7BBCB65128")]
		public void RequestUnlockAvatarAwakenComic(uint origionalID, uint comicID)
		{
		}

		// Token: 0x0600A4C1 RID: 42177 RVA: 0x0002BDE8 File Offset: 0x00029FE8
		[Token(Token = "0x600A4C1")]
		[Address(RVA = "0x2363F70", Offset = "0x2363F70", VA = "0x7BBCB63F70")]
		public uint GetExChangeAwakenAvatarID(uint avatarID)
		{
			return 0U;
		}

		// Token: 0x0600A4C2 RID: 42178 RVA: 0x0002BE00 File Offset: 0x0002A000
		[Token(Token = "0x600A4C2")]
		[Address(RVA = "0x236534C", Offset = "0x236534C", VA = "0x7BBCB6534C")]
		public uint AwakenIdToOriId(uint awakenAvatarID)
		{
			return 0U;
		}

		// Token: 0x0600A4C3 RID: 42179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4C3")]
		[Address(RVA = "0x23654F8", Offset = "0x23654F8", VA = "0x7BBCB654F8")]
		private void UpdateAvatarAwakenTask(List<AwakenTask> taskList)
		{
		}

		// Token: 0x0600A4C4 RID: 42180 RVA: 0x0002BE18 File Offset: 0x0002A018
		[Token(Token = "0x600A4C4")]
		[Address(RVA = "0x2365798", Offset = "0x2365798", VA = "0x7BBCB65798")]
		public bool CanClaimAwakenAvatarAward(uint oriAvatarID)
		{
			return default(bool);
		}

		// Token: 0x0600A4C5 RID: 42181 RVA: 0x0002BE30 File Offset: 0x0002A030
		[Token(Token = "0x600A4C5")]
		[Address(RVA = "0x2365B18", Offset = "0x2365B18", VA = "0x7BBCB65B18")]
		public uint GetOnlyAwakenId(uint avatarid)
		{
			return 0U;
		}

		// Token: 0x0600A4C6 RID: 42182 RVA: 0x0002BE48 File Offset: 0x0002A048
		[Token(Token = "0x600A4C6")]
		[Address(RVA = "0x2365B58", Offset = "0x2365B58", VA = "0x7BBCB65B58")]
		public uint GetOnlyOriginId(uint avatarid)
		{
			return 0U;
		}

		// Token: 0x0600A4C7 RID: 42183 RVA: 0x0002BE60 File Offset: 0x0002A060
		[Token(Token = "0x600A4C7")]
		[Address(RVA = "0x2364D60", Offset = "0x2364D60", VA = "0x7BBCB64D60")]
		public bool HasAwakenAvatar(uint avatarID)
		{
			return default(bool);
		}

		// Token: 0x0600A4C8 RID: 42184 RVA: 0x0002BE78 File Offset: 0x0002A078
		[Token(Token = "0x600A4C8")]
		[Address(RVA = "0x2365B98", Offset = "0x2365B98", VA = "0x7BBCB65B98")]
		public bool HasAvatar(uint id)
		{
			return default(bool);
		}

		// Token: 0x0600A4C9 RID: 42185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A4C9")]
		[Address(RVA = "0x2365C58", Offset = "0x2365C58", VA = "0x7BBCB65C58")]
		public List<AwakenTask> GetAwakenTaskList(uint oriAvatarID)
		{
			return null;
		}

		// Token: 0x0600A4CA RID: 42186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A4CA")]
		[Address(RVA = "0x2365D30", Offset = "0x2365D30", VA = "0x7BBCB65D30")]
		public AwakenTask GetAwakenTaskInfo(uint oriAvatarID, uint taskType)
		{
			return null;
		}

		// Token: 0x0600A4CB RID: 42187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4CB")]
		[Address(RVA = "0x2360674", Offset = "0x2360674", VA = "0x7BBCB60674")]
		public void RequestAvatarAwakenTaskDesc(bool force = false)
		{
		}

		// Token: 0x0600A4CC RID: 42188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4CC")]
		[Address(RVA = "0x2365E50", Offset = "0x2365E50", VA = "0x7BBCB65E50")]
		public void AutoOpenBundle(uint bundleID, [Optional] Action callback)
		{
		}

		// Token: 0x0600A4CD RID: 42189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4CD")]
		[Address(RVA = "0x2366008", Offset = "0x2366008", VA = "0x7BBCB66008")]
		public void OnAwakenTaskStateChange(List<AwakenTaskChangeInfo> res)
		{
		}

		// Token: 0x0600A4CE RID: 42190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4CE")]
		[Address(RVA = "0x23664EC", Offset = "0x23664EC", VA = "0x7BBCB664EC")]
		public void RequestClaimAwakenTaskReward(uint avatarID, uint taskID)
		{
		}

		// Token: 0x0600A4CF RID: 42191 RVA: 0x0002BE90 File Offset: 0x0002A090
		[Token(Token = "0x600A4CF")]
		[Address(RVA = "0x2366728", Offset = "0x2366728", VA = "0x7BBCB66728")]
		public bool HasUnClaimAwakenTaskReward(uint avatarID)
		{
			return default(bool);
		}

		// Token: 0x0600A4D0 RID: 42192 RVA: 0x0002BEA8 File Offset: 0x0002A0A8
		[Token(Token = "0x600A4D0")]
		[Address(RVA = "0x2366910", Offset = "0x2366910", VA = "0x7BBCB66910")]
		public bool HasNewUnlockAwakenComic(uint avatarID)
		{
			return default(bool);
		}

		// Token: 0x0600A4D1 RID: 42193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4D1")]
		[Address(RVA = "0x23661C0", Offset = "0x23661C0", VA = "0x7BBCB661C0")]
		public void UpdateAvatarAwakenTaskState(uint avatarID, uint taskId, proto.EProfile.TaskState state, uint process = 0U)
		{
		}

		// Token: 0x0600A4D2 RID: 42194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4D2")]
		[Address(RVA = "0x2366A40", Offset = "0x2366A40", VA = "0x7BBCB66A40")]
		public void RequestUpgradeAwakenSkill(uint avatarID)
		{
		}

		// Token: 0x0600A4D3 RID: 42195 RVA: 0x0002BEC0 File Offset: 0x0002A0C0
		[Token(Token = "0x600A4D3")]
		[Address(RVA = "0x2366A48", Offset = "0x2366A48", VA = "0x7BBCB66A48")]
		public bool CanUpgradeAwakenSkill(uint avatarID)
		{
			return default(bool);
		}

		// Token: 0x0600A4D4 RID: 42196 RVA: 0x0002BED8 File Offset: 0x0002A0D8
		[Token(Token = "0x600A4D4")]
		[Address(RVA = "0x2366C48", Offset = "0x2366C48", VA = "0x7BBCB66C48")]
		public bool ShowExchangeAwakenAvatarBtn(uint avatarID)
		{
			return default(bool);
		}

		// Token: 0x0600A4D5 RID: 42197 RVA: 0x0002BEF0 File Offset: 0x0002A0F0
		[Token(Token = "0x600A4D5")]
		[Address(RVA = "0x236584C", Offset = "0x236584C", VA = "0x7BBCB6584C")]
		public bool IsAwakenFinished(uint oriAvatarID)
		{
			return default(bool);
		}

		// Token: 0x0600A4D6 RID: 42198 RVA: 0x0002BF08 File Offset: 0x0002A108
		[Token(Token = "0x600A4D6")]
		[Address(RVA = "0x23605B4", Offset = "0x23605B4", VA = "0x7BBCB605B4")]
		public bool IsOriAvatrLevelSatisfyForAwaken(uint oriAvatarID)
		{
			return default(bool);
		}

		// Token: 0x0600A4D7 RID: 42199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A4D7")]
		[Address(RVA = "0x2366C88", Offset = "0x2366C88", VA = "0x7BBCB66C88")]
		public AvatarProfile GetAccountAvatarProfileById(ulong accountId)
		{
			return null;
		}

		// Token: 0x0600A4D8 RID: 42200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4D8")]
		[Address(RVA = "0x2366D08", Offset = "0x2366D08", VA = "0x7BBCB66D08")]
		public void ClearProfileAccountIDCache()
		{
		}

		// Token: 0x0600A4D9 RID: 42201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4D9")]
		[Address(RVA = "0x2366D68", Offset = "0x2366D68", VA = "0x7BBCB66D68")]
		public void TryRequestAvatarProfile(List<ulong> accountIDList, uint httpOp = 0U)
		{
		}

		// Token: 0x0600A4DA RID: 42202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4DA")]
		[Address(RVA = "0x2367148", Offset = "0x2367148", VA = "0x7BBCB67148")]
		private void BatchRequestAvatarProfileInCache()
		{
		}

		// Token: 0x0600A4DB RID: 42203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4DB")]
		[Address(RVA = "0x2366F3C", Offset = "0x2366F3C", VA = "0x7BBCB66F3C")]
		public void RequestGeAvatarProfileBatch(List<ulong> accountIdList, uint httpOp = 0U)
		{
		}

		// Token: 0x0600A4DC RID: 42204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4DC")]
		[Address(RVA = "0x2367300", Offset = "0x2367300", VA = "0x7BBCB67300")]
		public UIModelAvatarProfile()
		{
		}

		// Token: 0x0600A4DD RID: 42205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4DD")]
		[Address(RVA = "0x236777C", Offset = "0x236777C", VA = "0x7BBCB6777C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145ADC", Offset = "0x1145ADC")]
		private void <RequestMyAvatarList>b__82_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600A4DE RID: 42206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4DE")]
		[Address(RVA = "0x236798C", Offset = "0x236798C", VA = "0x7BBCB6798C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145AEC", Offset = "0x1145AEC")]
		private void <ForceRequestAvatarList>b__83_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600A4DF RID: 42207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4DF")]
		[Address(RVA = "0x2367AD4", Offset = "0x2367AD4", VA = "0x7BBCB67AD4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145AFC", Offset = "0x1145AFC")]
		private void <RequestSkillList>b__84_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600A4E0 RID: 42208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4E0")]
		[Address(RVA = "0x2367BEC", Offset = "0x2367BEC", VA = "0x7BBCB67BEC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145B0C", Offset = "0x1145B0C")]
		private void <RequestLoginGetProfile>b__85_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600A4E1 RID: 42209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4E1")]
		[Address(RVA = "0x23684F0", Offset = "0x23684F0", VA = "0x7BBCB684F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145B1C", Offset = "0x1145B1C")]
		private void <RequestLoginGetProfile>b__85_1()
		{
		}

		// Token: 0x0600A4E2 RID: 42210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4E2")]
		[Address(RVA = "0x23684F8", Offset = "0x23684F8", VA = "0x7BBCB684F8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145B2C", Offset = "0x1145B2C")]
		private void <RequestHideAvatars>b__87_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600A4E3 RID: 42211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4E3")]
		[Address(RVA = "0x23685E0", Offset = "0x23685E0", VA = "0x7BBCB685E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145B3C", Offset = "0x1145B3C")]
		private void <RequestEquipSkill>b__118_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600A4E4 RID: 42212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4E4")]
		[Address(RVA = "0x23687E8", Offset = "0x23687E8", VA = "0x7BBCB687E8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145B4C", Offset = "0x1145B4C")]
		private void <RequestClaimAvatarAwaken>b__149_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600A4E5 RID: 42213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4E5")]
		[Address(RVA = "0x2368CB0", Offset = "0x2368CB0", VA = "0x7BBCB68CB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145B5C", Offset = "0x1145B5C")]
		private void <RequestGetAvatarAwakenComicInfo>b__151_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600A4E6 RID: 42214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4E6")]
		[Address(RVA = "0x2368DF0", Offset = "0x2368DF0", VA = "0x7BBCB68DF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145B6C", Offset = "0x1145B6C")]
		private void <RequestAvatarAwakenTaskDesc>b__169_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0400AA6D RID: 43629
		[Token(Token = "0x400AA6D")]
		public const uint PropID_AvatarListUpdate = 2U;

		// Token: 0x0400AA6E RID: 43630
		[Token(Token = "0x400AA6E")]
		public const uint PropID_ProfileUpdate = 4U;

		// Token: 0x0400AA6F RID: 43631
		[Token(Token = "0x400AA6F")]
		public const uint PropID_SkillUpdate = 8U;

		// Token: 0x0400AA70 RID: 43632
		[Token(Token = "0x400AA70")]
		public const uint PropID_UnlockProfile = 16U;

		// Token: 0x0400AA71 RID: 43633
		[Token(Token = "0x400AA71")]
		public const uint PropID_UnlockAvatar = 32U;

		// Token: 0x0400AA72 RID: 43634
		[Token(Token = "0x400AA72")]
		public const uint PropID_SkillSlotChange = 64U;

		// Token: 0x0400AA73 RID: 43635
		[Token(Token = "0x400AA73")]
		public const uint PropID_AvatarSelectionChanged = 128U;

		// Token: 0x0400AA74 RID: 43636
		[Token(Token = "0x400AA74")]
		public const uint PropID_UnLockSkillSlot = 256U;

		// Token: 0x0400AA75 RID: 43637
		[Token(Token = "0x400AA75")]
		public const uint PropID_UpgradeProfile = 512U;

		// Token: 0x0400AA76 RID: 43638
		[Token(Token = "0x400AA76")]
		public const uint PropID_AwakenTaskUpdate = 1024U;

		// Token: 0x0400AA77 RID: 43639
		[Token(Token = "0x400AA77")]
		public const uint PropID_AwakenRewardClaim = 2048U;

		// Token: 0x0400AA78 RID: 43640
		[Token(Token = "0x400AA78")]
		public const uint PropID_ExchangeDebrisSuccess = 4096U;

		// Token: 0x0400AA79 RID: 43641
		[Token(Token = "0x400AA79")]
		public const uint PropID_LimitAvatarInfoChange = 8192U;

		// Token: 0x0400AA7A RID: 43642
		[Token(Token = "0x400AA7A")]
		public const uint PropID_LimitAvatarExpire = 16384U;

		// Token: 0x0400AA7B RID: 43643
		[Token(Token = "0x400AA7B")]
		public const uint PropID_GetAvatarProfileBatch = 32768U;

		// Token: 0x0400AA7C RID: 43644
		[Token(Token = "0x400AA7C")]
		public const uint PropID_AwakenComicUpdate = 65536U;

		// Token: 0x0400AA7D RID: 43645
		[Token(Token = "0x400AA7D")]
		public const uint PropID_AvatarAwakenUpdate = 131072U;

		// Token: 0x0400AA7E RID: 43646
		[Token(Token = "0x400AA7E")]
		public const string UPGRADECARDPREFIX = "UPGRADECARDPREFIX";

		// Token: 0x0400AA7F RID: 43647
		[Token(Token = "0x400AA7F")]
		public const string UPGRADECARDREDDOT = "UPGRADECARDREDDOT";

		// Token: 0x0400AA80 RID: 43648
		[Token(Token = "0x400AA80")]
		public const string AWAKENCOMICHASNEW = "AWAKENCOMICHASNEW";

		// Token: 0x0400AA81 RID: 43649
		[Token(Token = "0x400AA81")]
		public const uint AVATARAWAKEN_FINISH = 4294967295U;

		// Token: 0x0400AA82 RID: 43650
		[Token(Token = "0x400AA82")]
		private const uint UNIVERSAL_DEBRIS_ID = 817000001U;

		// Token: 0x0400AA83 RID: 43651
		[Token(Token = "0x400AA83")]
		private const uint DEFAULT_SELECT_AVATARID = 102000004U;

		// Token: 0x0400AA84 RID: 43652
		[Token(Token = "0x400AA84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint m_CurrentUnlockAvatarID;

		// Token: 0x0400AA85 RID: 43653
		[Token(Token = "0x400AA85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<uint, AvatarProfile> m_AvatarProfileMap;

		// Token: 0x0400AA86 RID: 43654
		[Token(Token = "0x400AA86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<uint> m_AvailableSkills;

		// Token: 0x0400AA87 RID: 43655
		[Token(Token = "0x400AA87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Dictionary<uint, AvatarSkill> AvatarSkillDataMap;

		// Token: 0x0400AA88 RID: 43656
		[Token(Token = "0x400AA88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<AvatarProfileDataOverrided> m_AvatarProfileDescList;

		// Token: 0x0400AA89 RID: 43657
		[Token(Token = "0x400AA89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<uint> m_HideAvatarList;

		// Token: 0x0400AA8A RID: 43658
		[Token(Token = "0x400AA8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<ulong, AvatarProfile> m_AccountAvatarDict;

		// Token: 0x0400AA8B RID: 43659
		[Token(Token = "0x400AA8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<AvatarLevelUpCard> m_LevelUpCardList;

		// Token: 0x0400AA8C RID: 43660
		[Token(Token = "0x400AA8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private AvatarProfile m_CurrentAvatar;

		// Token: 0x0400AA8D RID: 43661
		[Token(Token = "0x400AA8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int m_UniversalDebrisCnt;

		// Token: 0x0400AA8E RID: 43662
		[Token(Token = "0x400AA8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private string Key;

		// Token: 0x0400AA8F RID: 43663
		[Token(Token = "0x400AA8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_NewBieAvatarGuide;

		// Token: 0x0400AA90 RID: 43664
		[Token(Token = "0x400AA90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private uint m_SuitIdCache;

		// Token: 0x0400AA91 RID: 43665
		[Token(Token = "0x400AA91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Dictionary<uint, uint> m_OriAvatarIDToAwakenAvatarIdMap;

		// Token: 0x0400AA92 RID: 43666
		[Token(Token = "0x400AA92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Dictionary<uint, AvatarAwaken> m_OriAvatarIDToAwakenInfoMap;

		// Token: 0x0400AA93 RID: 43667
		[Token(Token = "0x400AA93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Dictionary<uint, AvatarAwaken> m_OriAvatarIDToAwakenInfoMap_lock;

		// Token: 0x0400AA94 RID: 43668
		[Token(Token = "0x400AA94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Dictionary<uint, Dictionary<uint, AwakenTask>> m_OriAvatarToAwakenTaskMap;

		// Token: 0x0400AA95 RID: 43669
		[Token(Token = "0x400AA95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Dictionary<uint, uint> m_OriAvatarToAwakenTaskRefreshCntMap;

		// Token: 0x0400AA96 RID: 43670
		[Token(Token = "0x400AA96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Dictionary<uint, Dictionary<uint, AwakenComic>> m_OriAvatarToAwakenComicMap;

		// Token: 0x0400AA97 RID: 43671
		[Token(Token = "0x400AA97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Dictionary<uint, List<GoPos>> m_AvatarIdToGoPosData;

		// Token: 0x0400AA98 RID: 43672
		[Token(Token = "0x400AA98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Dictionary<int, int> m_ProfileLvToSkillLv;

		// Token: 0x0400AA99 RID: 43673
		[Token(Token = "0x400AA99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<ulong> m_RunningRequestProfileAccountIDCache;

		// Token: 0x0400AA9A RID: 43674
		[Token(Token = "0x400AA9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private List<uint> m_HadReadRedDotList;

		// Token: 0x0400AA9B RID: 43675
		[Token(Token = "0x400AA9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool m_HasRequestedMyAvatarList;

		// Token: 0x0400AA9C RID: 43676
		[Token(Token = "0x400AA9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private List<uint> m_CacheExpireAvatarLst;

		// Token: 0x0400AA9D RID: 43677
		[Token(Token = "0x400AA9D")]
		public const uint COMICUNLOCKCNT_PERCOMIC_MAX = 3U;

		// Token: 0x0400AA9E RID: 43678
		[Token(Token = "0x400AA9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool m_HadFetchAwakenComicRes;

		// Token: 0x0400AA9F RID: 43679
		[Token(Token = "0x400AA9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD9")]
		private bool m_HadFetchAwakenTaskRes;

		// Token: 0x02001D6F RID: 7535
		[Token(Token = "0x2001D6F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBD44", Offset = "0x10FBD44")]
		private sealed class <>c__DisplayClass90_0
		{
			// Token: 0x0600A4E7 RID: 42215 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A4E7")]
			[Address(RVA = "0x22CF524", Offset = "0x22CF524", VA = "0x7BBCACF524")]
			public <>c__DisplayClass90_0()
			{
			}

			// Token: 0x0600A4E8 RID: 42216 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A4E8")]
			[Address(RVA = "0x22CF52C", Offset = "0x22CF52C", VA = "0x7BBCACF52C")]
			internal void <ChangeSimpleSelectedAvatar>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400AAA0 RID: 43680
			[Token(Token = "0x400AAA0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelAvatarProfile <>4__this;

			// Token: 0x0400AAA1 RID: 43681
			[Token(Token = "0x400AAA1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public uint selectedAvatarID;
		}

		// Token: 0x02001D70 RID: 7536
		[Token(Token = "0x2001D70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBD54", Offset = "0x10FBD54")]
		private sealed class <>c__DisplayClass91_0
		{
			// Token: 0x0600A4E9 RID: 42217 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A4E9")]
			[Address(RVA = "0x22CF6E0", Offset = "0x22CF6E0", VA = "0x7BBCACF6E0")]
			public <>c__DisplayClass91_0()
			{
			}

			// Token: 0x0600A4EA RID: 42218 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A4EA")]
			[Address(RVA = "0x22CF6E8", Offset = "0x22CF6E8", VA = "0x7BBCACF6E8")]
			internal void <ChangeSelectedAvatar>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400AAA2 RID: 43682
			[Token(Token = "0x400AAA2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelAvatarProfile <>4__this;

			// Token: 0x0400AAA3 RID: 43683
			[Token(Token = "0x400AAA3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public uint selectedAvatarID;

			// Token: 0x0400AAA4 RID: 43684
			[Token(Token = "0x400AAA4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CSSelectProfileReq req;

			// Token: 0x0400AAA5 RID: 43685
			[Token(Token = "0x400AAA5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool callFromAvatarList;
		}

		// Token: 0x02001D71 RID: 7537
		[Token(Token = "0x2001D71")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBD64", Offset = "0x10FBD64")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600A4EC RID: 42220 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A4EC")]
			[Address(RVA = "0x236905C", Offset = "0x236905C", VA = "0x7BBCB6905C")]
			public <>c()
			{
			}

			// Token: 0x0600A4ED RID: 42221 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A4ED")]
			[Address(RVA = "0x2369064", Offset = "0x2369064", VA = "0x7BBCB69064")]
			internal void <RequestUnlockAvatarHiddenly>b__98_0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0600A4EE RID: 42222 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A4EE")]
			[Address(RVA = "0x2369068", Offset = "0x2369068", VA = "0x7BBCB69068")]
			internal void <ShowRewardList>b__105_2()
			{
			}

			// Token: 0x0600A4EF RID: 42223 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A4EF")]
			[Address(RVA = "0x2369104", Offset = "0x2369104", VA = "0x7BBCB69104")]
			internal CommonRewardItemInfo <ShowRewardList>b__105_3(BaseItemInfo item)
			{
				return null;
			}

			// Token: 0x0600A4F0 RID: 42224 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A4F0")]
			[Address(RVA = "0x2369110", Offset = "0x2369110", VA = "0x7BBCB69110")]
			internal CommonRewardItemInfo <RequestUseUpgradeCard>b__106_2(Item item)
			{
				return null;
			}

			// Token: 0x0600A4F1 RID: 42225 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A4F1")]
			[Address(RVA = "0x236911C", Offset = "0x236911C", VA = "0x7BBCB6911C")]
			internal CommonRewardItemInfo <RequestUnLockSkillSlot>b__119_1(BaseItemInfo item)
			{
				return null;
			}

			// Token: 0x0600A4F2 RID: 42226 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A4F2")]
			[Address(RVA = "0x2369128", Offset = "0x2369128", VA = "0x7BBCB69128")]
			internal CommonRewardItemInfo <OnLimitAvatarChange>b__126_0(Item item)
			{
				return null;
			}

			// Token: 0x0600A4F3 RID: 42227 RVA: 0x0002BF20 File Offset: 0x0002A120
			[Token(Token = "0x600A4F3")]
			[Address(RVA = "0x2369134", Offset = "0x2369134", VA = "0x7BBCB69134")]
			internal uint <DoSelectOneAvatarShow>b__134_0(AvatarProfile p)
			{
				return 0U;
			}

			// Token: 0x0600A4F4 RID: 42228 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A4F4")]
			[Address(RVA = "0x2369160", Offset = "0x2369160", VA = "0x7BBCB69160")]
			internal CommonRewardItemInfo <RequestClaimAvatarAwaken>b__149_1(BaseItemInfo item)
			{
				return null;
			}

			// Token: 0x0600A4F5 RID: 42229 RVA: 0x0002BF38 File Offset: 0x0002A138
			[Token(Token = "0x600A4F5")]
			[Address(RVA = "0x236916C", Offset = "0x236916C", VA = "0x7BBCB6916C")]
			internal uint <AwakenIdToOriId>b__159_1(KeyValuePair<uint, uint> e)
			{
				return 0U;
			}

			// Token: 0x0600A4F6 RID: 42230 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A4F6")]
			[Address(RVA = "0x23691C0", Offset = "0x23691C0", VA = "0x7BBCB691C0")]
			internal CommonRewardItemInfo <AutoOpenBundle>b__170_1(BaseItemInfo item)
			{
				return null;
			}

			// Token: 0x0600A4F7 RID: 42231 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A4F7")]
			[Address(RVA = "0x23691CC", Offset = "0x23691CC", VA = "0x7BBCB691CC")]
			internal CommonRewardItemInfo <RequestClaimAwakenTaskReward>b__172_1(BaseItemInfo item)
			{
				return null;
			}

			// Token: 0x0600A4F8 RID: 42232 RVA: 0x0002BF50 File Offset: 0x0002A150
			[Token(Token = "0x600A4F8")]
			[Address(RVA = "0x23691D8", Offset = "0x23691D8", VA = "0x7BBCB691D8")]
			internal bool <RequestClaimAwakenTaskReward>b__172_2(CommonRewardItemInfo e)
			{
				return default(bool);
			}

			// Token: 0x0400AAA6 RID: 43686
			[Token(Token = "0x400AAA6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly UIModelAvatarProfile.<>c <>9;

			// Token: 0x0400AAA7 RID: 43687
			[Token(Token = "0x400AAA7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action<HttpErrorCode, object> <>9__98_0;

			// Token: 0x0400AAA8 RID: 43688
			[Token(Token = "0x400AAA8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Action <>9__105_2;

			// Token: 0x0400AAA9 RID: 43689
			[Token(Token = "0x400AAA9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Converter<BaseItemInfo, CommonRewardItemInfo> <>9__105_3;

			// Token: 0x0400AAAA RID: 43690
			[Token(Token = "0x400AAAA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Converter<Item, CommonRewardItemInfo> <>9__106_2;

			// Token: 0x0400AAAB RID: 43691
			[Token(Token = "0x400AAAB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Converter<BaseItemInfo, CommonRewardItemInfo> <>9__119_1;

			// Token: 0x0400AAAC RID: 43692
			[Token(Token = "0x400AAAC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static Converter<Item, CommonRewardItemInfo> <>9__126_0;

			// Token: 0x0400AAAD RID: 43693
			[Token(Token = "0x400AAAD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public static Func<AvatarProfile, uint> <>9__134_0;

			// Token: 0x0400AAAE RID: 43694
			[Token(Token = "0x400AAAE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public static Converter<BaseItemInfo, CommonRewardItemInfo> <>9__149_1;

			// Token: 0x0400AAAF RID: 43695
			[Token(Token = "0x400AAAF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public static Func<KeyValuePair<uint, uint>, uint> <>9__159_1;

			// Token: 0x0400AAB0 RID: 43696
			[Token(Token = "0x400AAB0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public static Converter<BaseItemInfo, CommonRewardItemInfo> <>9__170_1;

			// Token: 0x0400AAB1 RID: 43697
			[Token(Token = "0x400AAB1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public static Converter<BaseItemInfo, CommonRewardItemInfo> <>9__172_1;

			// Token: 0x0400AAB2 RID: 43698
			[Token(Token = "0x400AAB2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public static Predicate<CommonRewardItemInfo> <>9__172_2;
		}

		// Token: 0x02001D72 RID: 7538
		[Token(Token = "0x2001D72")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBD74", Offset = "0x10FBD74")]
		private sealed class <>c__DisplayClass103_0
		{
			// Token: 0x0600A4F9 RID: 42233 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A4F9")]
			[Address(RVA = "0x2360318", Offset = "0x2360318", VA = "0x7BBCB60318")]
			public <>c__DisplayClass103_0()
			{
			}

			// Token: 0x0600A4FA RID: 42234 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A4FA")]
			[Address(RVA = "0x2369238", Offset = "0x2369238", VA = "0x7BBCB69238")]
			internal void <RequestUnlockProfile>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400AAB3 RID: 43699
			[Token(Token = "0x400AAB3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelAvatarProfile <>4__this;

			// Token: 0x0400AAB4 RID: 43700
			[Token(Token = "0x400AAB4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AvatarProfile profile;

			// Token: 0x0400AAB5 RID: 43701
			[Token(Token = "0x400AAB5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public uint avatarID;
		}

		// Token: 0x02001D73 RID: 7539
		[Token(Token = "0x2001D73")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBD84", Offset = "0x10FBD84")]
		private sealed class <>c__DisplayClass105_0
		{
			// Token: 0x0600A4FB RID: 42235 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A4FB")]
			[Address(RVA = "0x22CC588", Offset = "0x22CC588", VA = "0x7BBCACC588")]
			public <>c__DisplayClass105_0()
			{
			}

			// Token: 0x0600A4FC RID: 42236 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A4FC")]
			[Address(RVA = "0x22CC590", Offset = "0x22CC590", VA = "0x7BBCACC590")]
			internal void <ShowRewardList>b__0()
			{
			}

			// Token: 0x0600A4FD RID: 42237 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A4FD")]
			[Address(RVA = "0x22CC654", Offset = "0x22CC654", VA = "0x7BBCACC654")]
			internal void <ShowRewardList>b__1()
			{
			}

			// Token: 0x0400AAB6 RID: 43702
			[Token(Token = "0x400AAB6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public BaseItemInfo awardItemInfo;
		}

		// Token: 0x02001D74 RID: 7540
		[Token(Token = "0x2001D74")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBD94", Offset = "0x10FBD94")]
		private sealed class <>c__DisplayClass106_0
		{
			// Token: 0x0600A4FE RID: 42238 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A4FE")]
			[Address(RVA = "0x22CC714", Offset = "0x22CC714", VA = "0x7BBCACC714")]
			public <>c__DisplayClass106_0()
			{
			}

			// Token: 0x0600A4FF RID: 42239 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A4FF")]
			[Address(RVA = "0x22CC71C", Offset = "0x22CC71C", VA = "0x7BBCACC71C")]
			internal void <RequestUseUpgradeCard>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400AAB7 RID: 43703
			[Token(Token = "0x400AAB7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelAvatarProfile <>4__this;

			// Token: 0x0400AAB8 RID: 43704
			[Token(Token = "0x400AAB8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int nowProfileLv;

			// Token: 0x0400AAB9 RID: 43705
			[Token(Token = "0x400AAB9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public uint avatarID;

			// Token: 0x0400AABA RID: 43706
			[Token(Token = "0x400AABA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public uint upgradeCardID;

			// Token: 0x0400AABB RID: 43707
			[Token(Token = "0x400AABB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int oldProfileLv;
		}

		// Token: 0x02001D75 RID: 7541
		[Token(Token = "0x2001D75")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBDA4", Offset = "0x10FBDA4")]
		private sealed class <>c__DisplayClass106_1
		{
			// Token: 0x0600A500 RID: 42240 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A500")]
			[Address(RVA = "0x22CD19C", Offset = "0x22CD19C", VA = "0x7BBCACD19C")]
			public <>c__DisplayClass106_1()
			{
			}

			// Token: 0x0600A501 RID: 42241 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A501")]
			[Address(RVA = "0x22CD1A4", Offset = "0x22CD1A4", VA = "0x7BBCACD1A4")]
			internal void <RequestUseUpgradeCard>b__1()
			{
			}

			// Token: 0x0400AABC RID: 43708
			[Token(Token = "0x400AABC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<Item> awardItems;
		}

		// Token: 0x02001D76 RID: 7542
		[Token(Token = "0x2001D76")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBDB4", Offset = "0x10FBDB4")]
		private sealed class <>c__DisplayClass116_0
		{
			// Token: 0x0600A502 RID: 42242 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A502")]
			[Address(RVA = "0x22CD3B8", Offset = "0x22CD3B8", VA = "0x7BBCACD3B8")]
			public <>c__DisplayClass116_0()
			{
			}

			// Token: 0x0600A503 RID: 42243 RVA: 0x0002BF68 File Offset: 0x0002A168
			[Token(Token = "0x600A503")]
			[Address(RVA = "0x22CD3C0", Offset = "0x22CD3C0", VA = "0x7BBCACD3C0")]
			internal bool <FindGoPosByTime>b__0(GoPos pos)
			{
				return default(bool);
			}

			// Token: 0x0400AABD RID: 43709
			[Token(Token = "0x400AABD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ulong now;
		}

		// Token: 0x02001D77 RID: 7543
		[Token(Token = "0x2001D77")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBDC4", Offset = "0x10FBDC4")]
		private sealed class <>c__DisplayClass119_0
		{
			// Token: 0x0600A504 RID: 42244 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A504")]
			[Address(RVA = "0x22CD438", Offset = "0x22CD438", VA = "0x7BBCACD438")]
			public <>c__DisplayClass119_0()
			{
			}

			// Token: 0x0600A505 RID: 42245 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A505")]
			[Address(RVA = "0x22CD440", Offset = "0x22CD440", VA = "0x7BBCACD440")]
			internal void <RequestUnLockSkillSlot>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0600A506 RID: 42246 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A506")]
			[Address(RVA = "0x22CD9BC", Offset = "0x22CD9BC", VA = "0x7BBCACD9BC")]
			internal void <RequestUnLockSkillSlot>b__2()
			{
			}

			// Token: 0x0400AABE RID: 43710
			[Token(Token = "0x400AABE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelAvatarProfile <>4__this;

			// Token: 0x0400AABF RID: 43711
			[Token(Token = "0x400AABF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public uint avatarID;

			// Token: 0x0400AAC0 RID: 43712
			[Token(Token = "0x400AAC0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int slotIndex;

			// Token: 0x0400AAC1 RID: 43713
			[Token(Token = "0x400AAC1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action <>9__2;
		}

		// Token: 0x02001D78 RID: 7544
		[Token(Token = "0x2001D78")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBDD4", Offset = "0x10FBDD4")]
		private sealed class <>c__DisplayClass120_0
		{
			// Token: 0x0600A507 RID: 42247 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A507")]
			[Address(RVA = "0x22CDC10", Offset = "0x22CDC10", VA = "0x7BBCACDC10")]
			public <>c__DisplayClass120_0()
			{
			}

			// Token: 0x0600A508 RID: 42248 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A508")]
			[Address(RVA = "0x22CDC18", Offset = "0x22CDC18", VA = "0x7BBCACDC18")]
			internal void <RequestUseUniversalDebris>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400AAC2 RID: 43714
			[Token(Token = "0x400AAC2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelAvatarProfile <>4__this;

			// Token: 0x0400AAC3 RID: 43715
			[Token(Token = "0x400AAC3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int oldDebrisCnt;

			// Token: 0x0400AAC4 RID: 43716
			[Token(Token = "0x400AAC4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int ExchangeUniversaldebrisCnt;

			// Token: 0x0400AAC5 RID: 43717
			[Token(Token = "0x400AAC5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public uint targetDebrisID;
		}

		// Token: 0x02001D79 RID: 7545
		[Token(Token = "0x2001D79")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBDE4", Offset = "0x10FBDE4")]
		private sealed class <>c__DisplayClass153_0
		{
			// Token: 0x0600A509 RID: 42249 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A509")]
			[Address(RVA = "0x22CDD84", Offset = "0x22CDD84", VA = "0x7BBCACDD84")]
			public <>c__DisplayClass153_0()
			{
			}

			// Token: 0x0600A50A RID: 42250 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A50A")]
			[Address(RVA = "0x22CDD8C", Offset = "0x22CDD8C", VA = "0x7BBCACDD8C")]
			internal void <RequestRefreshAvatarAwakenTaskInfo>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400AAC6 RID: 43718
			[Token(Token = "0x400AAC6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelAvatarProfile <>4__this;

			// Token: 0x0400AAC7 RID: 43719
			[Token(Token = "0x400AAC7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public uint origionalID;
		}

		// Token: 0x02001D7A RID: 7546
		[Token(Token = "0x2001D7A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBDF4", Offset = "0x10FBDF4")]
		private sealed class <>c__DisplayClass157_0
		{
			// Token: 0x0600A50B RID: 42251 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A50B")]
			[Address(RVA = "0x22CDF0C", Offset = "0x22CDF0C", VA = "0x7BBCACDF0C")]
			public <>c__DisplayClass157_0()
			{
			}

			// Token: 0x0600A50C RID: 42252 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A50C")]
			[Address(RVA = "0x22CDF14", Offset = "0x22CDF14", VA = "0x7BBCACDF14")]
			internal void <RequestUnlockAvatarAwakenComic>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400AAC8 RID: 43720
			[Token(Token = "0x400AAC8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelAvatarProfile <>4__this;

			// Token: 0x0400AAC9 RID: 43721
			[Token(Token = "0x400AAC9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public uint origionalID;

			// Token: 0x0400AACA RID: 43722
			[Token(Token = "0x400AACA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public uint comicID;

			// Token: 0x0400AACB RID: 43723
			[Token(Token = "0x400AACB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public uint unlockNum;
		}

		// Token: 0x02001D7B RID: 7547
		[Token(Token = "0x2001D7B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBE04", Offset = "0x10FBE04")]
		private sealed class <>c__DisplayClass159_0
		{
			// Token: 0x0600A50D RID: 42253 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A50D")]
			[Address(RVA = "0x22CE24C", Offset = "0x22CE24C", VA = "0x7BBCACE24C")]
			public <>c__DisplayClass159_0()
			{
			}

			// Token: 0x0600A50E RID: 42254 RVA: 0x0002BF80 File Offset: 0x0002A180
			[Token(Token = "0x600A50E")]
			[Address(RVA = "0x22CE254", Offset = "0x22CE254", VA = "0x7BBCACE254")]
			internal bool <AwakenIdToOriId>b__0(KeyValuePair<uint, uint> e)
			{
				return default(bool);
			}

			// Token: 0x0400AACC RID: 43724
			[Token(Token = "0x400AACC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public uint awakenAvatarID;
		}

		// Token: 0x02001D7C RID: 7548
		[Token(Token = "0x2001D7C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBE14", Offset = "0x10FBE14")]
		private sealed class <>c__DisplayClass170_0
		{
			// Token: 0x0600A50F RID: 42255 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A50F")]
			[Address(RVA = "0x22CE2C0", Offset = "0x22CE2C0", VA = "0x7BBCACE2C0")]
			public <>c__DisplayClass170_0()
			{
			}

			// Token: 0x0600A510 RID: 42256 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A510")]
			[Address(RVA = "0x22CE2C8", Offset = "0x22CE2C8", VA = "0x7BBCACE2C8")]
			internal void <AutoOpenBundle>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400AACD RID: 43725
			[Token(Token = "0x400AACD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action callback;
		}

		// Token: 0x02001D7D RID: 7549
		[Token(Token = "0x2001D7D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBE24", Offset = "0x10FBE24")]
		private sealed class <>c__DisplayClass172_0
		{
			// Token: 0x0600A511 RID: 42257 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A511")]
			[Address(RVA = "0x22CEA34", Offset = "0x22CEA34", VA = "0x7BBCACEA34")]
			public <>c__DisplayClass172_0()
			{
			}

			// Token: 0x0600A512 RID: 42258 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A512")]
			[Address(RVA = "0x22CEA3C", Offset = "0x22CEA3C", VA = "0x7BBCACEA3C")]
			internal void <RequestClaimAwakenTaskReward>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400AACE RID: 43726
			[Token(Token = "0x400AACE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelAvatarProfile <>4__this;

			// Token: 0x0400AACF RID: 43727
			[Token(Token = "0x400AACF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public uint avatarID;

			// Token: 0x0400AAD0 RID: 43728
			[Token(Token = "0x400AAD0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public uint taskID;
		}

		// Token: 0x02001D7E RID: 7550
		[Token(Token = "0x2001D7E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBE34", Offset = "0x10FBE34")]
		private sealed class <>c__DisplayClass172_1
		{
			// Token: 0x0600A513 RID: 42259 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A513")]
			[Address(RVA = "0x22CEF00", Offset = "0x22CEF00", VA = "0x7BBCACEF00")]
			public <>c__DisplayClass172_1()
			{
			}

			// Token: 0x0600A514 RID: 42260 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A514")]
			[Address(RVA = "0x22CEF08", Offset = "0x22CEF08", VA = "0x7BBCACEF08")]
			internal void <RequestClaimAwakenTaskReward>b__3()
			{
			}

			// Token: 0x0400AAD1 RID: 43729
			[Token(Token = "0x400AAD1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<CommonRewardItemInfo> normalItems;

			// Token: 0x0400AAD2 RID: 43730
			[Token(Token = "0x400AAD2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UIModelAvatarProfile.<>c__DisplayClass172_0 CS$<>8__locals1;
		}

		// Token: 0x02001D7F RID: 7551
		[Token(Token = "0x2001D7F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBE44", Offset = "0x10FBE44")]
		private sealed class <>c__DisplayClass185_0
		{
			// Token: 0x0600A515 RID: 42261 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A515")]
			[Address(RVA = "0x22CF148", Offset = "0x22CF148", VA = "0x7BBCACF148")]
			public <>c__DisplayClass185_0()
			{
			}

			// Token: 0x0600A516 RID: 42262 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A516")]
			[Address(RVA = "0x22CF150", Offset = "0x22CF150", VA = "0x7BBCACF150")]
			internal void <RequestGeAvatarProfileBatch>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400AAD3 RID: 43731
			[Token(Token = "0x400AAD3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelAvatarProfile <>4__this;

			// Token: 0x0400AAD4 RID: 43732
			[Token(Token = "0x400AAD4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<ulong> accountIdList;
		}
	}
}
