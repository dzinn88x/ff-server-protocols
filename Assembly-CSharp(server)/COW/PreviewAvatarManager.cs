using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001282 RID: 4738
	[Token(Token = "0x2001282")]
	public class PreviewAvatarManager
	{
		// Token: 0x06004968 RID: 18792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004968")]
		[Address(RVA = "0x1744B7C", Offset = "0x1744B7C", VA = "0x7BBBF44B7C")]
		public static void GetOptionalClothRes(uint itemID, ref List<ResourceID> cloth_res_list)
		{
		}

		// Token: 0x06004969 RID: 18793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004969")]
		[Address(RVA = "0x1744D7C", Offset = "0x1744D7C", VA = "0x7BBBF44D7C")]
		public static void GetOptionalClothRes(uint[] item_id_list, ref List<ResourceID> cloth_res_list)
		{
		}

		// Token: 0x0600496A RID: 18794 RVA: 0x00016368 File Offset: 0x00014568
		[Token(Token = "0x600496A")]
		[Address(RVA = "0x1744E78", Offset = "0x1744E78", VA = "0x7BBBF44E78")]
		public static bool CheckClothABReady(uint itemID)
		{
			return default(bool);
		}

		// Token: 0x0600496B RID: 18795 RVA: 0x00016380 File Offset: 0x00014580
		[Token(Token = "0x600496B")]
		[Address(RVA = "0x1745094", Offset = "0x1745094", VA = "0x7BBBF45094")]
		public static bool IsClothBundleABReady(uint[] bundles)
		{
			return default(bool);
		}

		// Token: 0x0600496C RID: 18796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600496C")]
		[Address(RVA = "0x174518C", Offset = "0x174518C", VA = "0x7BBBF4518C")]
		public static void ClearAvatarPool()
		{
		}

		// Token: 0x0600496D RID: 18797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600496D")]
		[Address(RVA = "0x1745380", Offset = "0x1745380", VA = "0x7BBBF45380")]
		public static void PushAvatar()
		{
		}

		// Token: 0x0600496E RID: 18798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600496E")]
		[Address(RVA = "0x1745504", Offset = "0x1745504", VA = "0x7BBBF45504")]
		public static void RecycleAvatar(UIMaleAvatar avatar)
		{
		}

		// Token: 0x0600496F RID: 18799 RVA: 0x00016398 File Offset: 0x00014598
		[Token(Token = "0x600496F")]
		[Address(RVA = "0x17458D8", Offset = "0x17458D8", VA = "0x7BBBF458D8")]
		private static int GetUsefulAvatarIndex(bool isfemale)
		{
			return 0;
		}

		// Token: 0x06004970 RID: 18800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004970")]
		[Address(RVA = "0x17456F4", Offset = "0x17456F4", VA = "0x7BBBF456F4")]
		public static void SetAvatarLightLayer(UIMaleAvatar avatar, string layername, string shadowname)
		{
		}

		// Token: 0x06004971 RID: 18801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004971")]
		[Address(RVA = "0x1745B5C", Offset = "0x1745B5C", VA = "0x7BBBF45B5C")]
		public static UIMaleAvatar CreateAvatar(List<uint> idlist, Vector3 scale, Vector3 pos, bool playSpecial, int avatarlighttype = 1, bool changeanim = true, int doubleanimid = 0, string resspecial = "", string residle = "", bool createwithlight = true)
		{
			return null;
		}

		// Token: 0x06004972 RID: 18802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004972")]
		[Address(RVA = "0x1746CA0", Offset = "0x1746CA0", VA = "0x7BBBF46CA0")]
		public static UIPetAvatar CreatePetAvatar(uint pet_id, Vector3 scale, Vector3 pos, int avatarlighttype = 1, [Optional] Quaternion rotation)
		{
			return null;
		}

		// Token: 0x06004973 RID: 18803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004973")]
		[Address(RVA = "0x1747088", Offset = "0x1747088", VA = "0x7BBBF47088")]
		public static void ResetAvatarDir(UIMaleAvatar avatar)
		{
		}

		// Token: 0x06004974 RID: 18804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004974")]
		[Address(RVA = "0x1747188", Offset = "0x1747188", VA = "0x7BBBF47188")]
		public static void SetGameobjectLayer(GameObject avatarobj, int layer)
		{
		}

		// Token: 0x06004975 RID: 18805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004975")]
		[Address(RVA = "0x174647C", Offset = "0x174647C", VA = "0x7BBBF4647C")]
		public static void PreviewClothes(UIMaleAvatar avatar, uint avatarId, uint selectClothes, uint[] clothes, bool addLobbyClothes, bool playClothesAnim, bool keepHairWhenSameAvatarId, bool changeanim = true, int doubleanimid = 0, bool playTriggerEffect = true)
		{
		}

		// Token: 0x06004976 RID: 18806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004976")]
		[Address(RVA = "0x1747274", Offset = "0x1747274", VA = "0x7BBBF47274")]
		public PreviewAvatarManager()
		{
		}

		// Token: 0x04007244 RID: 29252
		[Token(Token = "0x4007244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static List<UIMaleAvatar> UImaleAvatarPool;

		// Token: 0x04007245 RID: 29253
		[Token(Token = "0x4007245")]
		public const string FORTUNEIdleAnimId = "INGAME_ANIMATION_COS_FORTUNE_IDLE_MALE";

		// Token: 0x04007246 RID: 29254
		[Token(Token = "0x4007246")]
		public const string PHOENIXAnimId = "INGAME_ANIMATION_COS_PHOENIX_IDLE_FEMALE";

		// Token: 0x04007247 RID: 29255
		[Token(Token = "0x4007247")]
		public const string SanTaGirlSpecialAnimId = "INGAME_ANIMATION_DOUBLEANIM_SANTAGIRL_SPECIAL";

		// Token: 0x04007248 RID: 29256
		[Token(Token = "0x4007248")]
		public const string SanTaGirlIdleAnimId = "INGAME_ANIMATION_DOUBLEANIM_SANTAGIRL_IDLE";

		// Token: 0x04007249 RID: 29257
		[Token(Token = "0x4007249")]
		public const string SanTaBoySpecialAnimId = "INGAME_ANIMATION_DOUBLEANIM_SANTABOY_SPECIAL";

		// Token: 0x0400724A RID: 29258
		[Token(Token = "0x400724A")]
		public const string SanTaBoyIdleAnimId = "INGAME_ANIMATION_DOUBLEANIM_SANTABOY_IDLE";

		// Token: 0x02001283 RID: 4739
		[Token(Token = "0x2001283")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EB020", Offset = "0x10EB020")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004979 RID: 18809 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004979")]
			[Address(RVA = "0x1747354", Offset = "0x1747354", VA = "0x7BBBF47354")]
			public <>c()
			{
			}

			// Token: 0x0600497A RID: 18810 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600497A")]
			[Address(RVA = "0x174735C", Offset = "0x174735C", VA = "0x7BBBF4735C")]
			internal void <PreviewClothes>b__20_0(UIStatedAvatar s)
			{
			}

			// Token: 0x0400724B RID: 29259
			[Token(Token = "0x400724B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly PreviewAvatarManager.<>c <>9;

			// Token: 0x0400724C RID: 29260
			[Token(Token = "0x400724C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action<UIStatedAvatar> <>9__20_0;
		}
	}
}
