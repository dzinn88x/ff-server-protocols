using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using tcp;

namespace COW
{
	// Token: 0x02001FA6 RID: 8102
	[Token(Token = "0x2001FA6")]
	internal class UIModelPet : UIBaseModel
	{
		// Token: 0x0600B3B7 RID: 46007 RVA: 0x00032EC8 File Offset: 0x000310C8
		[Token(Token = "0x600B3B7")]
		[Address(RVA = "0x23888C4", Offset = "0x23888C4", VA = "0x7BBCB888C4", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x17000C2F RID: 3119
		// (get) Token: 0x0600B3B8 RID: 46008 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B3B9 RID: 46009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C2F")]
		public List<proto.PetInfo> OwnPetList
		{
			[Token(Token = "0x600B3B8")]
			[Address(RVA = "0x23888CC", Offset = "0x23888CC", VA = "0x7BBCB888CC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146CFC", Offset = "0x1146CFC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600B3B9")]
			[Address(RVA = "0x23888D4", Offset = "0x23888D4", VA = "0x7BBCB888D4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146D0C", Offset = "0x1146D0C")]
			private set
			{
			}
		}

		// Token: 0x17000C30 RID: 3120
		// (get) Token: 0x0600B3BA RID: 46010 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B3BB RID: 46011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C30")]
		public List<proto.PetInfo> AllPetList
		{
			[Token(Token = "0x600B3BA")]
			[Address(RVA = "0x23888DC", Offset = "0x23888DC", VA = "0x7BBCB888DC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146D1C", Offset = "0x1146D1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600B3BB")]
			[Address(RVA = "0x23888E4", Offset = "0x23888E4", VA = "0x7BBCB888E4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146D2C", Offset = "0x1146D2C")]
			private set
			{
			}
		}

		// Token: 0x17000C31 RID: 3121
		// (get) Token: 0x0600B3BC RID: 46012 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B3BD RID: 46013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C31")]
		public List<PetActionInfo> OwnActionList
		{
			[Token(Token = "0x600B3BC")]
			[Address(RVA = "0x23888EC", Offset = "0x23888EC", VA = "0x7BBCB888EC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146D3C", Offset = "0x1146D3C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600B3BD")]
			[Address(RVA = "0x23888F4", Offset = "0x23888F4", VA = "0x7BBCB888F4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146D4C", Offset = "0x1146D4C")]
			private set
			{
			}
		}

		// Token: 0x17000C32 RID: 3122
		// (get) Token: 0x0600B3BE RID: 46014 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B3BF RID: 46015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C32")]
		public List<PetSkinInfo> OwnSkinList
		{
			[Token(Token = "0x600B3BE")]
			[Address(RVA = "0x23888FC", Offset = "0x23888FC", VA = "0x7BBCB888FC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146D5C", Offset = "0x1146D5C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600B3BF")]
			[Address(RVA = "0x2388904", Offset = "0x2388904", VA = "0x7BBCB88904")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146D6C", Offset = "0x1146D6C")]
			private set
			{
			}
		}

		// Token: 0x17000C33 RID: 3123
		// (get) Token: 0x0600B3C0 RID: 46016 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B3C1 RID: 46017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C33")]
		public List<proto.PetSkillInfo> OwnSkillList
		{
			[Token(Token = "0x600B3C0")]
			[Address(RVA = "0x238890C", Offset = "0x238890C", VA = "0x7BBCB8890C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146D7C", Offset = "0x1146D7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600B3C1")]
			[Address(RVA = "0x2388914", Offset = "0x2388914", VA = "0x7BBCB88914")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146D8C", Offset = "0x1146D8C")]
			private set
			{
			}
		}

		// Token: 0x0600B3C2 RID: 46018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3C2")]
		[Address(RVA = "0x238891C", Offset = "0x238891C", VA = "0x7BBCB8891C", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x0600B3C3 RID: 46019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3C3")]
		[Address(RVA = "0x23889E0", Offset = "0x23889E0", VA = "0x7BBCB889E0")]
		public void UpdatePetCarryInfo(proto.PetInfo data)
		{
		}

		// Token: 0x0600B3C4 RID: 46020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3C4")]
		[Address(RVA = "0x2388BB0", Offset = "0x2388BB0", VA = "0x7BBCB88BB0")]
		public void UpdatePetInfoList(List<proto.PetInfo> list)
		{
		}

		// Token: 0x0600B3C5 RID: 46021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3C5")]
		[Address(RVA = "0x23890A0", Offset = "0x23890A0", VA = "0x7BBCB890A0")]
		public void SetShowingPetPanel(bool show_state)
		{
		}

		// Token: 0x0600B3C6 RID: 46022 RVA: 0x00032EE0 File Offset: 0x000310E0
		[Token(Token = "0x600B3C6")]
		[Address(RVA = "0x23890AC", Offset = "0x23890AC", VA = "0x7BBCB890AC")]
		public bool CheckNeedShowPetLevelUp()
		{
			return default(bool);
		}

		// Token: 0x0600B3C7 RID: 46023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3C7")]
		[Address(RVA = "0x238911C", Offset = "0x238911C", VA = "0x7BBCB8911C")]
		public void ClearLastExpData()
		{
		}

		// Token: 0x0600B3C8 RID: 46024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B3C8")]
		[Address(RVA = "0x2389124", Offset = "0x2389124", VA = "0x7BBCB89124")]
		public PetLevelUpNtf GetLevelUpData()
		{
			return null;
		}

		// Token: 0x0600B3C9 RID: 46025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3C9")]
		[Address(RVA = "0x238912C", Offset = "0x238912C", VA = "0x7BBCB8912C")]
		public void SetShowNewTag(uint item_id)
		{
		}

		// Token: 0x0600B3CA RID: 46026 RVA: 0x00032EF8 File Offset: 0x000310F8
		[Token(Token = "0x600B3CA")]
		[Address(RVA = "0x23891D8", Offset = "0x23891D8", VA = "0x7BBCB891D8")]
		public bool IsHideShowNewTag(uint item_id)
		{
			return default(bool);
		}

		// Token: 0x0600B3CB RID: 46027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3CB")]
		[Address(RVA = "0x2389254", Offset = "0x2389254", VA = "0x7BBCB89254")]
		public void RemoveNewTag(uint item_id)
		{
		}

		// Token: 0x0600B3CC RID: 46028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3CC")]
		[Address(RVA = "0x2389300", Offset = "0x2389300", VA = "0x7BBCB89300")]
		public void UpdatePetSelectedInfo(proto.PetInfo info)
		{
		}

		// Token: 0x0600B3CD RID: 46029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3CD")]
		[Address(RVA = "0x2389338", Offset = "0x2389338", VA = "0x7BBCB89338")]
		public void UpdatePetSkinIDSelected(uint skinID)
		{
		}

		// Token: 0x0600B3CE RID: 46030 RVA: 0x00032F10 File Offset: 0x00031110
		[Token(Token = "0x600B3CE")]
		[Address(RVA = "0x2389340", Offset = "0x2389340", VA = "0x7BBCB89340")]
		public uint GetSelectedPetSkinID()
		{
			return 0U;
		}

		// Token: 0x0600B3CF RID: 46031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B3CF")]
		[Address(RVA = "0x2389348", Offset = "0x2389348", VA = "0x7BBCB89348")]
		public proto.PetInfo GetSelectedPetInfo()
		{
			return null;
		}

		// Token: 0x0600B3D0 RID: 46032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B3D0")]
		[Address(RVA = "0x2388CD8", Offset = "0x2388CD8", VA = "0x7BBCB88CD8")]
		private List<proto.PetInfo> GetAllPetList()
		{
			return null;
		}

		// Token: 0x0600B3D1 RID: 46033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3D1")]
		[Address(RVA = "0x2389358", Offset = "0x2389358", VA = "0x7BBCB89358")]
		public void CheckPetNewFlag()
		{
		}

		// Token: 0x0600B3D2 RID: 46034 RVA: 0x00032F28 File Offset: 0x00031128
		[Token(Token = "0x600B3D2")]
		[Address(RVA = "0x2389974", Offset = "0x2389974", VA = "0x7BBCB89974")]
		public bool CheckPetSkinNewFlag(int id, bool add_tip)
		{
			return default(bool);
		}

		// Token: 0x0600B3D3 RID: 46035 RVA: 0x00032F40 File Offset: 0x00031140
		[Token(Token = "0x600B3D3")]
		[Address(RVA = "0x238A09C", Offset = "0x238A09C", VA = "0x7BBCB8A09C")]
		public bool CheckPetSkillFlag(int id, bool add_tip)
		{
			return default(bool);
		}

		// Token: 0x0600B3D4 RID: 46036 RVA: 0x00032F58 File Offset: 0x00031158
		[Token(Token = "0x600B3D4")]
		[Address(RVA = "0x2389D08", Offset = "0x2389D08", VA = "0x7BBCB89D08")]
		public bool CheckPetActionFlag(int id, bool add_tip)
		{
			return default(bool);
		}

		// Token: 0x0600B3D5 RID: 46037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B3D5")]
		[Address(RVA = "0x238A420", Offset = "0x238A420", VA = "0x7BBCB8A420")]
		public List<proto.PetInfo> GetPetInfoCanShow()
		{
			return null;
		}

		// Token: 0x0600B3D6 RID: 46038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3D6")]
		[Address(RVA = "0x238A69C", Offset = "0x238A69C", VA = "0x7BBCB8A69C", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600B3D7 RID: 46039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3D7")]
		[Address(RVA = "0x238A710", Offset = "0x238A710", VA = "0x7BBCB8A710")]
		public void GetMyPetInfoData(bool force = false)
		{
		}

		// Token: 0x0600B3D8 RID: 46040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3D8")]
		[Address(RVA = "0x238A8C4", Offset = "0x238A8C4", VA = "0x7BBCB8A8C4")]
		public void NotifyPetDataRefresh()
		{
		}

		// Token: 0x0600B3D9 RID: 46041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3D9")]
		[Address(RVA = "0x238A990", Offset = "0x238A990", VA = "0x7BBCB8A990")]
		public void SelectPet(uint pet_id, bool carry_state)
		{
		}

		// Token: 0x0600B3DA RID: 46042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3DA")]
		[Address(RVA = "0x238ABD8", Offset = "0x238ABD8", VA = "0x7BBCB8ABD8")]
		public void FeedPet(uint pet_id, uint food_id, uint food_count)
		{
		}

		// Token: 0x0600B3DB RID: 46043 RVA: 0x00032F70 File Offset: 0x00031170
		[Token(Token = "0x600B3DB")]
		[Address(RVA = "0x238AE18", Offset = "0x238AE18", VA = "0x7BBCB8AE18")]
		public uint GetPetExpMaxLevel(int pet_id)
		{
			return 0U;
		}

		// Token: 0x0600B3DC RID: 46044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3DC")]
		[Address(RVA = "0x238AED8", Offset = "0x238AED8", VA = "0x7BBCB8AED8")]
		public void OnReceivedFeedData(PetLevelUpNtf data)
		{
		}

		// Token: 0x0600B3DD RID: 46045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3DD")]
		[Address(RVA = "0x238BF60", Offset = "0x238BF60", VA = "0x7BBCB8BF60")]
		public void RenamePet(uint pet_id, string name)
		{
		}

		// Token: 0x0600B3DE RID: 46046 RVA: 0x00032F88 File Offset: 0x00031188
		[Token(Token = "0x600B3DE")]
		[Address(RVA = "0x238C190", Offset = "0x238C190", VA = "0x7BBCB8C190")]
		public uint GetFoodItemByPetID(uint pet_id)
		{
			return 0U;
		}

		// Token: 0x0600B3DF RID: 46047 RVA: 0x00032FA0 File Offset: 0x000311A0
		[Token(Token = "0x600B3DF")]
		[Address(RVA = "0x238C474", Offset = "0x238C474", VA = "0x7BBCB8C474")]
		public int GetFoodItemExpByPetID(uint pet_id)
		{
			return 0;
		}

		// Token: 0x0600B3E0 RID: 46048 RVA: 0x00032FB8 File Offset: 0x000311B8
		[Token(Token = "0x600B3E0")]
		[Address(RVA = "0x238C758", Offset = "0x238C758", VA = "0x7BBCB8C758")]
		public uint GetCurrentCarryPetID()
		{
			return 0U;
		}

		// Token: 0x0600B3E1 RID: 46049 RVA: 0x00032FD0 File Offset: 0x000311D0
		[Token(Token = "0x600B3E1")]
		[Address(RVA = "0x238C770", Offset = "0x238C770", VA = "0x7BBCB8C770")]
		public bool CheckPetLockState(proto.PetInfo pet_info)
		{
			return default(bool);
		}

		// Token: 0x0600B3E2 RID: 46050 RVA: 0x00032FE8 File Offset: 0x000311E8
		[Token(Token = "0x600B3E2")]
		[Address(RVA = "0x238C78C", Offset = "0x238C78C", VA = "0x7BBCB8C78C")]
		public uint GetCurrentCarryPetSkinID()
		{
			return 0U;
		}

		// Token: 0x0600B3E3 RID: 46051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B3E3")]
		[Address(RVA = "0x238C7A4", Offset = "0x238C7A4", VA = "0x7BBCB8C7A4")]
		public proto.PetInfo GetCurrentCarryPetInfo()
		{
			return null;
		}

		// Token: 0x0600B3E4 RID: 46052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B3E4")]
		[Address(RVA = "0x2389848", Offset = "0x2389848", VA = "0x7BBCB89848")]
		public proto.PetInfo GetPetInfoById(uint m_id)
		{
			return null;
		}

		// Token: 0x0600B3E5 RID: 46053 RVA: 0x00033000 File Offset: 0x00031200
		[Token(Token = "0x600B3E5")]
		[Address(RVA = "0x238C7AC", Offset = "0x238C7AC", VA = "0x7BBCB8C7AC")]
		public ResourceID GetPetResourceID(uint pet_id)
		{
			return default(ResourceID);
		}

		// Token: 0x0600B3E6 RID: 46054 RVA: 0x00033018 File Offset: 0x00031218
		[Token(Token = "0x600B3E6")]
		[Address(RVA = "0x238C894", Offset = "0x238C894", VA = "0x7BBCB8C894")]
		public ResourceID GetSkinResourceID(uint skin_id)
		{
			return default(ResourceID);
		}

		// Token: 0x0600B3E7 RID: 46055 RVA: 0x00033030 File Offset: 0x00031230
		[Token(Token = "0x600B3E7")]
		[Address(RVA = "0x238C97C", Offset = "0x238C97C", VA = "0x7BBCB8C97C")]
		public PetConfigInfo GetNextPetConfigByID(uint pet_id, uint Lv)
		{
			return default(PetConfigInfo);
		}

		// Token: 0x0600B3E8 RID: 46056 RVA: 0x00033048 File Offset: 0x00031248
		[Token(Token = "0x600B3E8")]
		[Address(RVA = "0x238C99C", Offset = "0x238C99C", VA = "0x7BBCB8C99C")]
		public PetConfigInfo GetCurrentPetConfigByID(uint pet_id, uint Lv)
		{
			return default(PetConfigInfo);
		}

		// Token: 0x0600B3E9 RID: 46057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B3E9")]
		[Address(RVA = "0x2389604", Offset = "0x2389604", VA = "0x7BBCB89604")]
		public List<PetData> GetPetConfigList()
		{
			return null;
		}

		// Token: 0x0600B3EA RID: 46058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B3EA")]
		[Address(RVA = "0x238C9B8", Offset = "0x238C9B8", VA = "0x7BBCB8C9B8")]
		public PetData GetPetDataByID(uint pet_id)
		{
			return null;
		}

		// Token: 0x0600B3EB RID: 46059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B3EB")]
		[Address(RVA = "0x238CA68", Offset = "0x238CA68", VA = "0x7BBCB8CA68")]
		public List<PetActionData> GetUnlockPetAnims(uint petid)
		{
			return null;
		}

		// Token: 0x0600B3EC RID: 46060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B3EC")]
		[Address(RVA = "0x238CCF0", Offset = "0x238CCF0", VA = "0x7BBCB8CCF0")]
		public string GetDefaultNameByID(uint pet_id)
		{
			return null;
		}

		// Token: 0x0600B3ED RID: 46061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3ED")]
		[Address(RVA = "0x238CE28", Offset = "0x238CE28", VA = "0x7BBCB8CE28")]
		public void SelectPetSkin(uint skin_id, uint pet_id, bool notifyCommonReward = false)
		{
		}

		// Token: 0x0600B3EE RID: 46062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3EE")]
		[Address(RVA = "0x238D0C8", Offset = "0x238D0C8", VA = "0x7BBCB8D0C8")]
		public void SelectPetSkill(uint pet_id, uint pet_skill_id)
		{
		}

		// Token: 0x0600B3EF RID: 46063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3EF")]
		[Address(RVA = "0x238D30C", Offset = "0x238D30C", VA = "0x7BBCB8D30C")]
		public void UpdateNewItem(Item[] newInventories)
		{
		}

		// Token: 0x0600B3F0 RID: 46064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3F0")]
		[Address(RVA = "0x238D7D4", Offset = "0x238D7D4", VA = "0x7BBCB8D7D4")]
		public UIModelPet()
		{
		}

		// Token: 0x0600B3F1 RID: 46065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3F1")]
		[Address(RVA = "0x238D864", Offset = "0x238D864", VA = "0x7BBCB8D864")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146D9C", Offset = "0x1146D9C")]
		private void <GetMyPetInfoData>b__61_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0400B634 RID: 46644
		[Token(Token = "0x400B634")]
		public const uint PropID_UpdatePetExp = 2U;

		// Token: 0x0400B635 RID: 46645
		[Token(Token = "0x400B635")]
		public const uint PropID_UpdatePetCarry = 4U;

		// Token: 0x0400B636 RID: 46646
		[Token(Token = "0x400B636")]
		public const uint PropID_UpdatePetInfo = 8U;

		// Token: 0x0400B637 RID: 46647
		[Token(Token = "0x400B637")]
		public const uint PropID_RenameSuccess = 16U;

		// Token: 0x0400B638 RID: 46648
		[Token(Token = "0x400B638")]
		public const uint PropID_RenameError = 32U;

		// Token: 0x0400B639 RID: 46649
		[Token(Token = "0x400B639")]
		public const uint PropID_UpdatePetFeed = 64U;

		// Token: 0x0400B63A RID: 46650
		[Token(Token = "0x400B63A")]
		public const uint PropID_PetInfoLevelUp = 128U;

		// Token: 0x0400B63B RID: 46651
		[Token(Token = "0x400B63B")]
		public const uint PropID_PetActionListGet = 256U;

		// Token: 0x0400B63C RID: 46652
		[Token(Token = "0x400B63C")]
		public const uint PropID_PetSkinListGet = 512U;

		// Token: 0x0400B63D RID: 46653
		[Token(Token = "0x400B63D")]
		public const uint PropID_PetSkinSelected = 1024U;

		// Token: 0x0400B63E RID: 46654
		[Token(Token = "0x400B63E")]
		public const uint PropID_PetSkillListGet = 2048U;

		// Token: 0x0400B63F RID: 46655
		[Token(Token = "0x400B63F")]
		public const uint PropID_PetNewTagChange = 4096U;

		// Token: 0x0400B640 RID: 46656
		[Token(Token = "0x400B640")]
		public const uint PropID_PetSkillSelected = 8192U;

		// Token: 0x0400B641 RID: 46657
		[Token(Token = "0x400B641")]
		[FieldOffset(Offset = "0x18")]
		private proto.PetInfo m_CarryPetInfo;

		// Token: 0x0400B642 RID: 46658
		[Token(Token = "0x400B642")]
		[FieldOffset(Offset = "0x20")]
		private PetLevelUpNtf last_exp_data;

		// Token: 0x0400B643 RID: 46659
		[Token(Token = "0x400B643")]
		[FieldOffset(Offset = "0x28")]
		private proto.PetInfo m_CurrentSelectedPetInfo;

		// Token: 0x0400B644 RID: 46660
		[Token(Token = "0x400B644")]
		[FieldOffset(Offset = "0x30")]
		private uint m_CurrentSelectedPetSkinID;

		// Token: 0x0400B645 RID: 46661
		[Token(Token = "0x400B645")]
		[FieldOffset(Offset = "0x34")]
		private bool isShowPetPanel;

		// Token: 0x0400B646 RID: 46662
		[Token(Token = "0x400B646")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113035C", Offset = "0x113035C")]
		private List<proto.PetInfo> <OwnPetList>k__BackingField;

		// Token: 0x0400B647 RID: 46663
		[Token(Token = "0x400B647")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113036C", Offset = "0x113036C")]
		private List<proto.PetInfo> <AllPetList>k__BackingField;

		// Token: 0x0400B648 RID: 46664
		[Token(Token = "0x400B648")]
		[FieldOffset(Offset = "0x48")]
		private List<uint> m_newTagList;

		// Token: 0x0400B649 RID: 46665
		[Token(Token = "0x400B649")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113037C", Offset = "0x113037C")]
		private List<PetActionInfo> <OwnActionList>k__BackingField;

		// Token: 0x0400B64A RID: 46666
		[Token(Token = "0x400B64A")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113038C", Offset = "0x113038C")]
		private List<PetSkinInfo> <OwnSkinList>k__BackingField;

		// Token: 0x0400B64B RID: 46667
		[Token(Token = "0x400B64B")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113039C", Offset = "0x113039C")]
		private List<proto.PetSkillInfo> <OwnSkillList>k__BackingField;

		// Token: 0x02001FA7 RID: 8103
		[Token(Token = "0x2001FA7")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD434", Offset = "0x10FD434")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600B3F3 RID: 46067 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B3F3")]
			[Address(RVA = "0x238DA14", Offset = "0x238DA14", VA = "0x7BBCB8DA14")]
			public <>c()
			{
			}

			// Token: 0x0600B3F4 RID: 46068 RVA: 0x00033060 File Offset: 0x00031260
			[Token(Token = "0x600B3F4")]
			[Address(RVA = "0x238DA1C", Offset = "0x238DA1C", VA = "0x7BBCB8DA1C")]
			internal bool <UpdatePetInfoList>b__42_0(proto.PetInfo temp)
			{
				return default(bool);
			}

			// Token: 0x0600B3F5 RID: 46069 RVA: 0x00033078 File Offset: 0x00031278
			[Token(Token = "0x600B3F5")]
			[Address(RVA = "0x238DA48", Offset = "0x238DA48", VA = "0x7BBCB8DA48")]
			internal bool <SelectPet>b__63_1(proto.PetInfo temp)
			{
				return default(bool);
			}

			// Token: 0x0600B3F6 RID: 46070 RVA: 0x00033090 File Offset: 0x00031290
			[Token(Token = "0x600B3F6")]
			[Address(RVA = "0x238DA74", Offset = "0x238DA74", VA = "0x7BBCB8DA74")]
			internal bool <SelectPet>b__63_3(proto.PetInfo temp)
			{
				return default(bool);
			}

			// Token: 0x0400B64C RID: 46668
			[Token(Token = "0x400B64C")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIModelPet.<>c <>9;

			// Token: 0x0400B64D RID: 46669
			[Token(Token = "0x400B64D")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<proto.PetInfo> <>9__42_0;

			// Token: 0x0400B64E RID: 46670
			[Token(Token = "0x400B64E")]
			[FieldOffset(Offset = "0x10")]
			public static Predicate<proto.PetInfo> <>9__63_1;

			// Token: 0x0400B64F RID: 46671
			[Token(Token = "0x400B64F")]
			[FieldOffset(Offset = "0x18")]
			public static Predicate<proto.PetInfo> <>9__63_3;
		}

		// Token: 0x02001FA8 RID: 8104
		[Token(Token = "0x2001FA8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD444", Offset = "0x10FD444")]
		private sealed class <>c__DisplayClass54_0
		{
			// Token: 0x0600B3F7 RID: 46071 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B3F7")]
			[Address(RVA = "0x2389350", Offset = "0x2389350", VA = "0x7BBCB89350")]
			public <>c__DisplayClass54_0()
			{
			}

			// Token: 0x0600B3F8 RID: 46072 RVA: 0x000330A8 File Offset: 0x000312A8
			[Token(Token = "0x600B3F8")]
			[Address(RVA = "0x238DAA0", Offset = "0x238DAA0", VA = "0x7BBCB8DAA0")]
			internal bool <GetAllPetList>b__0(proto.PetInfo temp)
			{
				return default(bool);
			}

			// Token: 0x0400B650 RID: 46672
			[Token(Token = "0x400B650")]
			[FieldOffset(Offset = "0x10")]
			public PetData petCfg;
		}

		// Token: 0x02001FA9 RID: 8105
		[Token(Token = "0x2001FA9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD454", Offset = "0x10FD454")]
		private sealed class <>c__DisplayClass63_0
		{
			// Token: 0x0600B3F9 RID: 46073 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B3F9")]
			[Address(RVA = "0x238ABD0", Offset = "0x238ABD0", VA = "0x7BBCB8ABD0")]
			public <>c__DisplayClass63_0()
			{
			}

			// Token: 0x0600B3FA RID: 46074 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B3FA")]
			[Address(RVA = "0x238DAEC", Offset = "0x238DAEC", VA = "0x7BBCB8DAEC")]
			internal void <SelectPet>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0600B3FB RID: 46075 RVA: 0x000330C0 File Offset: 0x000312C0
			[Token(Token = "0x600B3FB")]
			[Address(RVA = "0x238E08C", Offset = "0x238E08C", VA = "0x7BBCB8E08C")]
			internal bool <SelectPet>b__2(proto.PetInfo temp)
			{
				return default(bool);
			}

			// Token: 0x0400B651 RID: 46673
			[Token(Token = "0x400B651")]
			[FieldOffset(Offset = "0x10")]
			public UIModelPet <>4__this;

			// Token: 0x0400B652 RID: 46674
			[Token(Token = "0x400B652")]
			[FieldOffset(Offset = "0x18")]
			public uint pet_id;

			// Token: 0x0400B653 RID: 46675
			[Token(Token = "0x400B653")]
			[FieldOffset(Offset = "0x1C")]
			public bool carry_state;

			// Token: 0x0400B654 RID: 46676
			[Token(Token = "0x400B654")]
			[FieldOffset(Offset = "0x20")]
			public Predicate<proto.PetInfo> <>9__2;
		}

		// Token: 0x02001FAA RID: 8106
		[Token(Token = "0x2001FAA")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD464", Offset = "0x10FD464")]
		private sealed class <>c__DisplayClass64_0
		{
			// Token: 0x0600B3FC RID: 46076 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B3FC")]
			[Address(RVA = "0x238AE10", Offset = "0x238AE10", VA = "0x7BBCB8AE10")]
			public <>c__DisplayClass64_0()
			{
			}

			// Token: 0x0600B3FD RID: 46077 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B3FD")]
			[Address(RVA = "0x238E0C8", Offset = "0x238E0C8", VA = "0x7BBCB8E0C8")]
			internal void <FeedPet>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0600B3FE RID: 46078 RVA: 0x000330D8 File Offset: 0x000312D8
			[Token(Token = "0x600B3FE")]
			[Address(RVA = "0x238E330", Offset = "0x238E330", VA = "0x7BBCB8E330")]
			internal bool <FeedPet>b__1(proto.PetInfo temp)
			{
				return default(bool);
			}

			// Token: 0x0400B655 RID: 46677
			[Token(Token = "0x400B655")]
			[FieldOffset(Offset = "0x10")]
			public UIModelPet <>4__this;

			// Token: 0x0400B656 RID: 46678
			[Token(Token = "0x400B656")]
			[FieldOffset(Offset = "0x18")]
			public uint pet_id;

			// Token: 0x0400B657 RID: 46679
			[Token(Token = "0x400B657")]
			[FieldOffset(Offset = "0x20")]
			public Predicate<proto.PetInfo> <>9__1;
		}

		// Token: 0x02001FAB RID: 8107
		[Token(Token = "0x2001FAB")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD474", Offset = "0x10FD474")]
		private sealed class <>c__DisplayClass66_0
		{
			// Token: 0x0600B3FF RID: 46079 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B3FF")]
			[Address(RVA = "0x238BF58", Offset = "0x238BF58", VA = "0x7BBCB8BF58")]
			public <>c__DisplayClass66_0()
			{
			}

			// Token: 0x0600B400 RID: 46080 RVA: 0x000330F0 File Offset: 0x000312F0
			[Token(Token = "0x600B400")]
			[Address(RVA = "0x238E36C", Offset = "0x238E36C", VA = "0x7BBCB8E36C")]
			internal bool <OnReceivedFeedData>b__0(proto.PetInfo temp)
			{
				return default(bool);
			}

			// Token: 0x0400B658 RID: 46680
			[Token(Token = "0x400B658")]
			[FieldOffset(Offset = "0x10")]
			public PetLevelUpNtf data;
		}

		// Token: 0x02001FAC RID: 8108
		[Token(Token = "0x2001FAC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD484", Offset = "0x10FD484")]
		private sealed class <>c__DisplayClass67_0
		{
			// Token: 0x0600B401 RID: 46081 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B401")]
			[Address(RVA = "0x238C188", Offset = "0x238C188", VA = "0x7BBCB8C188")]
			public <>c__DisplayClass67_0()
			{
			}

			// Token: 0x0600B402 RID: 46082 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B402")]
			[Address(RVA = "0x238E3C0", Offset = "0x238E3C0", VA = "0x7BBCB8E3C0")]
			internal void <RenamePet>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0600B403 RID: 46083 RVA: 0x00033108 File Offset: 0x00031308
			[Token(Token = "0x600B403")]
			[Address(RVA = "0x238E7D8", Offset = "0x238E7D8", VA = "0x7BBCB8E7D8")]
			internal bool <RenamePet>b__1(proto.PetInfo temp)
			{
				return default(bool);
			}

			// Token: 0x0400B659 RID: 46681
			[Token(Token = "0x400B659")]
			[FieldOffset(Offset = "0x10")]
			public UIModelPet <>4__this;

			// Token: 0x0400B65A RID: 46682
			[Token(Token = "0x400B65A")]
			[FieldOffset(Offset = "0x18")]
			public uint pet_id;

			// Token: 0x0400B65B RID: 46683
			[Token(Token = "0x400B65B")]
			[FieldOffset(Offset = "0x20")]
			public Predicate<proto.PetInfo> <>9__1;
		}

		// Token: 0x02001FAD RID: 8109
		[Token(Token = "0x2001FAD")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD494", Offset = "0x10FD494")]
		private sealed class <>c__DisplayClass83_0
		{
			// Token: 0x0600B404 RID: 46084 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B404")]
			[Address(RVA = "0x238D0C0", Offset = "0x238D0C0", VA = "0x7BBCB8D0C0")]
			public <>c__DisplayClass83_0()
			{
			}

			// Token: 0x0600B405 RID: 46085 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B405")]
			[Address(RVA = "0x238E814", Offset = "0x238E814", VA = "0x7BBCB8E814")]
			internal void <SelectPetSkin>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0600B406 RID: 46086 RVA: 0x00033120 File Offset: 0x00031320
			[Token(Token = "0x600B406")]
			[Address(RVA = "0x238EC40", Offset = "0x238EC40", VA = "0x7BBCB8EC40")]
			internal bool <SelectPetSkin>b__1(proto.PetInfo temp)
			{
				return default(bool);
			}

			// Token: 0x0400B65C RID: 46684
			[Token(Token = "0x400B65C")]
			[FieldOffset(Offset = "0x10")]
			public UIModelPet <>4__this;

			// Token: 0x0400B65D RID: 46685
			[Token(Token = "0x400B65D")]
			[FieldOffset(Offset = "0x18")]
			public uint pet_id;

			// Token: 0x0400B65E RID: 46686
			[Token(Token = "0x400B65E")]
			[FieldOffset(Offset = "0x1C")]
			public uint skin_id;

			// Token: 0x0400B65F RID: 46687
			[Token(Token = "0x400B65F")]
			[FieldOffset(Offset = "0x20")]
			public bool notifyCommonReward;

			// Token: 0x0400B660 RID: 46688
			[Token(Token = "0x400B660")]
			[FieldOffset(Offset = "0x28")]
			public Predicate<proto.PetInfo> <>9__1;
		}

		// Token: 0x02001FAE RID: 8110
		[Token(Token = "0x2001FAE")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD4A4", Offset = "0x10FD4A4")]
		private sealed class <>c__DisplayClass84_0
		{
			// Token: 0x0600B407 RID: 46087 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B407")]
			[Address(RVA = "0x238D304", Offset = "0x238D304", VA = "0x7BBCB8D304")]
			public <>c__DisplayClass84_0()
			{
			}

			// Token: 0x0600B408 RID: 46088 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B408")]
			[Address(RVA = "0x238EC7C", Offset = "0x238EC7C", VA = "0x7BBCB8EC7C")]
			internal void <SelectPetSkill>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0600B409 RID: 46089 RVA: 0x00033138 File Offset: 0x00031338
			[Token(Token = "0x600B409")]
			[Address(RVA = "0x238EE54", Offset = "0x238EE54", VA = "0x7BBCB8EE54")]
			internal bool <SelectPetSkill>b__1(proto.PetInfo temp)
			{
				return default(bool);
			}

			// Token: 0x0400B661 RID: 46689
			[Token(Token = "0x400B661")]
			[FieldOffset(Offset = "0x10")]
			public UIModelPet <>4__this;

			// Token: 0x0400B662 RID: 46690
			[Token(Token = "0x400B662")]
			[FieldOffset(Offset = "0x18")]
			public uint pet_id;

			// Token: 0x0400B663 RID: 46691
			[Token(Token = "0x400B663")]
			[FieldOffset(Offset = "0x1C")]
			public uint pet_skill_id;

			// Token: 0x0400B664 RID: 46692
			[Token(Token = "0x400B664")]
			[FieldOffset(Offset = "0x20")]
			public Predicate<proto.PetInfo> <>9__1;
		}

		// Token: 0x02001FAF RID: 8111
		[Token(Token = "0x2001FAF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD4B4", Offset = "0x10FD4B4")]
		private sealed class <>c__DisplayClass85_0
		{
			// Token: 0x0600B40A RID: 46090 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B40A")]
			[Address(RVA = "0x238D7CC", Offset = "0x238D7CC", VA = "0x7BBCB8D7CC")]
			public <>c__DisplayClass85_0()
			{
			}

			// Token: 0x0600B40B RID: 46091 RVA: 0x00033150 File Offset: 0x00031350
			[Token(Token = "0x600B40B")]
			[Address(RVA = "0x238EE90", Offset = "0x238EE90", VA = "0x7BBCB8EE90")]
			internal bool <UpdateNewItem>b__0(proto.PetInfo temp)
			{
				return default(bool);
			}

			// Token: 0x0400B665 RID: 46693
			[Token(Token = "0x400B665")]
			[FieldOffset(Offset = "0x10")]
			public PetSkinData SkinData;
		}
	}
}
