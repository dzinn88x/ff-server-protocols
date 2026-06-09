using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001343 RID: 4931
	[Token(Token = "0x2001343")]
	public class CSSharedAvatarDataManager : SingletonModule<CSSharedAvatarDataManager>
	{
		// Token: 0x06004E4F RID: 20047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E4F")]
		[Address(RVA = "0x14EF3FC", Offset = "0x14EF3FC", VA = "0x7BBBCEF3FC", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x06004E50 RID: 20048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E50")]
		[Address(RVA = "0x14EF4B4", Offset = "0x14EF4B4", VA = "0x7BBBCEF4B4", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x06004E51 RID: 20049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E51")]
		[Address(RVA = "0x14EFBD4", Offset = "0x14EFBD4", VA = "0x7BBBCEFBD4")]
		public CSSharedAvatarData FindCSSharedAvatarDataById(uint InId)
		{
			return null;
		}

		// Token: 0x06004E52 RID: 20050 RVA: 0x00017E38 File Offset: 0x00016038
		[Token(Token = "0x6004E52")]
		[Address(RVA = "0x14EFC5C", Offset = "0x14EFC5C", VA = "0x7BBBCEFC5C")]
		public bool IsAvatarCantEquipHeadAdditive(uint avatarId)
		{
			return default(bool);
		}

		// Token: 0x06004E53 RID: 20051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E53")]
		[Address(RVA = "0x14EFC80", Offset = "0x14EFC80", VA = "0x7BBBCEFC80")]
		public List<CSSharedAvatarData> FindCSSharedAvatarListByGender(int gender)
		{
			return null;
		}

		// Token: 0x06004E54 RID: 20052 RVA: 0x00017E50 File Offset: 0x00016050
		[Token(Token = "0x6004E54")]
		[Address(RVA = "0x14EFD08", Offset = "0x14EFD08", VA = "0x7BBBCEFD08")]
		public uint FindDefaultAvatarIDByGender(int gender)
		{
			return 0U;
		}

		// Token: 0x06004E55 RID: 20053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E55")]
		[Address(RVA = "0x14EFE40", Offset = "0x14EFE40", VA = "0x7BBBCEFE40")]
		public uint[] AllPVEWeapons()
		{
			return null;
		}

		// Token: 0x06004E56 RID: 20054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E56")]
		[Address(RVA = "0x14F00A4", Offset = "0x14F00A4", VA = "0x7BBBCF00A4")]
		public CSSharedAvatarData FindAvatarDataByPVEWeapon(uint weaponID)
		{
			return null;
		}

		// Token: 0x06004E57 RID: 20055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E57")]
		[Address(RVA = "0x14F0224", Offset = "0x14F0224", VA = "0x7BBBCF0224")]
		public AvatarAwakenTaskData GetAvatarAwakenTaskData(uint avatarID, uint taskType)
		{
			return null;
		}

		// Token: 0x06004E58 RID: 20056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E58")]
		[Address(RVA = "0x14F0344", Offset = "0x14F0344", VA = "0x7BBBCF0344")]
		public List<AvatarAwakenTaskData> GetAwakenTaskList(uint avatarID)
		{
			return null;
		}

		// Token: 0x06004E59 RID: 20057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E59")]
		[Address(RVA = "0x14F04AC", Offset = "0x14F04AC", VA = "0x7BBBCF04AC")]
		public AvatarAwakenComicData GetAwakenComicData(uint avatarID, uint comicID)
		{
			return null;
		}

		// Token: 0x06004E5A RID: 20058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E5A")]
		[Address(RVA = "0x14F0560", Offset = "0x14F0560", VA = "0x7BBBCF0560")]
		public List<AvatarAwakenComicData> GetAwakenComicConfigList(uint avatarID)
		{
			return null;
		}

		// Token: 0x06004E5B RID: 20059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E5B")]
		[Address(RVA = "0x14F0860", Offset = "0x14F0860", VA = "0x7BBBCF0860")]
		public AvatarAwakenTaskRefreshData GetAvatarAwakenTaskRefreshData(uint avatarID)
		{
			return null;
		}

		// Token: 0x06004E5C RID: 20060 RVA: 0x00017E68 File Offset: 0x00016068
		[Token(Token = "0x6004E5C")]
		[Address(RVA = "0x14F0910", Offset = "0x14F0910", VA = "0x7BBBCF0910")]
		public bool HasAvatarFacialExpressionData()
		{
			return default(bool);
		}

		// Token: 0x06004E5D RID: 20061 RVA: 0x00017E80 File Offset: 0x00016080
		[Token(Token = "0x6004E5D")]
		[Address(RVA = "0x14F0918", Offset = "0x14F0918", VA = "0x7BBBCF0918")]
		public ResourceID GetRandomAvatarFacialExpressionAnimRes(uint avatarID, UIModelAvatarBase.EWardrobeType type)
		{
			return default(ResourceID);
		}

		// Token: 0x06004E5E RID: 20062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E5E")]
		[Address(RVA = "0x14F0980", Offset = "0x14F0980", VA = "0x7BBBCF0980")]
		public CSSharedAvatarDataManager()
		{
		}

		// Token: 0x04007566 RID: 30054
		[Token(Token = "0x4007566")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<uint, CSSharedAvatarData> m_dictIdToAvatarData;

		// Token: 0x04007567 RID: 30055
		[Token(Token = "0x4007567")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<int, List<CSSharedAvatarData>> m_dictGenderToAvatarData;

		// Token: 0x04007568 RID: 30056
		[Token(Token = "0x4007568")]
		[FieldOffset(Offset = "0x28")]
		private List<uint> m_DefaultPVEWeapons;

		// Token: 0x04007569 RID: 30057
		[Token(Token = "0x4007569")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<uint, Dictionary<uint, AvatarAwakenTaskData>> m_dicToAvatarAwakenTaskData;
	}
}
