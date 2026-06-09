using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;
using UMA.Simple;
using UnityEngine;

namespace COW
{
	// Token: 0x02001D6A RID: 7530
	[Token(Token = "0x2001D6A")]
	public class UIModelAvatar : UIModelAvatarBase
	{
		// Token: 0x0600A418 RID: 42008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A418")]
		[Address(RVA = "0x2354A70", Offset = "0x2354A70", VA = "0x7BBCB54A70", Slot = "8")]
		public override void Login(params object[] data)
		{
		}

		// Token: 0x0600A419 RID: 42009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A419")]
		[Address(RVA = "0x2354B74", Offset = "0x2354B74", VA = "0x7BBCB54B74")]
		public void RefreshDefaultModelId(GetOppositeSexModelRes res)
		{
		}

		// Token: 0x0600A41A RID: 42010 RVA: 0x0002B818 File Offset: 0x00029A18
		[Token(Token = "0x600A41A")]
		[Address(RVA = "0x2354C94", Offset = "0x2354C94", VA = "0x7BBCB54C94")]
		public uint GetDefaultModelId(bool isfamale)
		{
			return 0U;
		}

		// Token: 0x0600A41B RID: 42011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A41B")]
		[Address(RVA = "0x2354CAC", Offset = "0x2354CAC", VA = "0x7BBCB54CAC", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600A41C RID: 42012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A41C")]
		[Address(RVA = "0x2354D78", Offset = "0x2354D78", VA = "0x7BBCB54D78", Slot = "12")]
		protected override void OnSceneChange(params object[] data)
		{
		}

		// Token: 0x0600A41D RID: 42013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A41D")]
		[Address(RVA = "0x2354DD4", Offset = "0x2354DD4", VA = "0x7BBCB54DD4")]
		public static void ClearCachedRecipeReadyDict()
		{
		}

		// Token: 0x0600A41E RID: 42014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A41E")]
		[Address(RVA = "0x2354EA8", Offset = "0x2354EA8", VA = "0x7BBCB54EA8")]
		public Dictionary<UIModelAvatarBase.EGenderType, List<CSSharedAvatarData>> GetBackpackAvatarDict()
		{
			return null;
		}

		// Token: 0x0600A41F RID: 42015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A41F")]
		[Address(RVA = "0x2354EB0", Offset = "0x2354EB0", VA = "0x7BBCB54EB0")]
		public Dictionary<UIModelAvatarBase.EWardrobeType, List<InventoryClothInfo>> GetBackpackClothDict()
		{
			return null;
		}

		// Token: 0x0600A420 RID: 42016 RVA: 0x0002B830 File Offset: 0x00029A30
		[Token(Token = "0x600A420")]
		[Address(RVA = "0x2354EB8", Offset = "0x2354EB8", VA = "0x7BBCB54EB8")]
		public bool HasCurrentAvatar()
		{
			return default(bool);
		}

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x0600A421 RID: 42017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ADC")]
		public UIModelAvatarBase.AvatarData CurrentAvatarData
		{
			[Token(Token = "0x600A421")]
			[Address(RVA = "0x2354EC8", Offset = "0x2354EC8", VA = "0x7BBCB54EC8")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600A422 RID: 42018 RVA: 0x0002B848 File Offset: 0x00029A48
		[Token(Token = "0x600A422")]
		[Address(RVA = "0x2354ED0", Offset = "0x2354ED0", VA = "0x7BBCB54ED0")]
		public uint GetAvatarID()
		{
			return 0U;
		}

		// Token: 0x0600A423 RID: 42019 RVA: 0x0002B860 File Offset: 0x00029A60
		[Token(Token = "0x600A423")]
		[Address(RVA = "0x2354EE8", Offset = "0x2354EE8", VA = "0x7BBCB54EE8")]
		public bool IsSelfFemale()
		{
			return default(bool);
		}

		// Token: 0x0600A424 RID: 42020 RVA: 0x0002B878 File Offset: 0x00029A78
		[Token(Token = "0x600A424")]
		[Address(RVA = "0x2354F08", Offset = "0x2354F08", VA = "0x7BBCB54F08")]
		public UIModelAvatarBase.EHairType SelfHairType()
		{
			return UIModelAvatarBase.EHairType.HAIRTYPENONE;
		}

		// Token: 0x0600A425 RID: 42021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A425")]
		[Address(RVA = "0x2354F20", Offset = "0x2354F20", VA = "0x7BBCB54F20")]
		public string GetBaseRaceName()
		{
			return null;
		}

		// Token: 0x0600A426 RID: 42022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A426")]
		[Address(RVA = "0x2354FF8", Offset = "0x2354FF8", VA = "0x7BBCB54FF8")]
		public static string GetBaseRaceName(UIModelAvatarBase.EGenderType t, bool useHigh = true)
		{
			return null;
		}

		// Token: 0x0600A427 RID: 42023 RVA: 0x0002B890 File Offset: 0x00029A90
		[Token(Token = "0x600A427")]
		[Address(RVA = "0x2355114", Offset = "0x2355114", VA = "0x7BBCB55114")]
		public float GetSkinColorNormalized()
		{
			return 0f;
		}

		// Token: 0x0600A428 RID: 42024 RVA: 0x0002B8A8 File Offset: 0x00029AA8
		[Token(Token = "0x600A428")]
		[Address(RVA = "0x2355140", Offset = "0x2355140", VA = "0x7BBCB55140")]
		public float GetSkinColorNormalizedByAvatarID(uint avatarID)
		{
			return 0f;
		}

		// Token: 0x0600A429 RID: 42025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A429")]
		[Address(RVA = "0x23551E4", Offset = "0x23551E4", VA = "0x7BBCB551E4")]
		public Dictionary<int, uint> GetCurrentClothDict()
		{
			return null;
		}

		// Token: 0x0600A42A RID: 42026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A42A")]
		[Address(RVA = "0x2355210", Offset = "0x2355210", VA = "0x7BBCB55210")]
		public Dictionary<int, uint> GetCachedClothDict()
		{
			return null;
		}

		// Token: 0x0600A42B RID: 42027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A42B")]
		[Address(RVA = "0x235523C", Offset = "0x235523C", VA = "0x7BBCB5523C")]
		public Dictionary<int, uint> GetCurrentClothDict(uint avatarId)
		{
			return null;
		}

		// Token: 0x0600A42C RID: 42028 RVA: 0x0002B8C0 File Offset: 0x00029AC0
		[Token(Token = "0x600A42C")]
		[Address(RVA = "0x23552CC", Offset = "0x23552CC", VA = "0x7BBCB552CC")]
		public uint GetCurrentHair()
		{
			return 0U;
		}

		// Token: 0x0600A42D RID: 42029 RVA: 0x0002B8D8 File Offset: 0x00029AD8
		[Token(Token = "0x600A42D")]
		[Address(RVA = "0x235543C", Offset = "0x235543C", VA = "0x7BBCB5543C")]
		public bool IsClothesIdsTheSameWithCurrent(List<uint> clothesList)
		{
			return default(bool);
		}

		// Token: 0x0600A42E RID: 42030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A42E")]
		[Address(RVA = "0x2355594", Offset = "0x2355594", VA = "0x7BBCB55594")]
		public void UpdateAvatarList(AvatarProfile[] avatarList)
		{
		}

		// Token: 0x0600A42F RID: 42031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A42F")]
		[Address(RVA = "0x23559E4", Offset = "0x23559E4", VA = "0x7BBCB559E4")]
		public void UpdateAvatar(AvatarProfile avatar)
		{
		}

		// Token: 0x0600A430 RID: 42032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A430")]
		[Address(RVA = "0x2355C64", Offset = "0x2355C64", VA = "0x7BBCB55C64")]
		public void AfterGetBackPack(Dictionary<UIModelAvatarBase.EGenderType, List<CSSharedAvatarData>> dictAvatar, Dictionary<UIModelAvatarBase.EWardrobeType, List<InventoryClothInfo>> dictWardrobe)
		{
		}

		// Token: 0x0600A431 RID: 42033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A431")]
		[Address(RVA = "0x2355CDC", Offset = "0x2355CDC", VA = "0x7BBCB55CDC")]
		public void UpdateCurAvatarId(uint id)
		{
		}

		// Token: 0x0600A432 RID: 42034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A432")]
		[Address(RVA = "0x2355DD8", Offset = "0x2355DD8", VA = "0x7BBCB55DD8")]
		public void LocalSaveAvatarColor(uint v)
		{
		}

		// Token: 0x0600A433 RID: 42035 RVA: 0x0002B8F0 File Offset: 0x00029AF0
		[Token(Token = "0x600A433")]
		[Address(RVA = "0x2355E14", Offset = "0x2355E14", VA = "0x7BBCB55E14")]
		public bool RemoveSetSlotInNeed(AvatarWardrobeData data)
		{
			return default(bool);
		}

		// Token: 0x0600A434 RID: 42036 RVA: 0x0002B908 File Offset: 0x00029B08
		[Token(Token = "0x600A434")]
		[Address(RVA = "0x2355F34", Offset = "0x2355F34", VA = "0x7BBCB55F34")]
		public bool RemoveConflictSlotInNeed(AvatarWardrobeData data, bool removeSuppress = false)
		{
			return default(bool);
		}

		// Token: 0x0600A435 RID: 42037 RVA: 0x0002B920 File Offset: 0x00029B20
		[Token(Token = "0x600A435")]
		[Address(RVA = "0x235618C", Offset = "0x235618C", VA = "0x7BBCB5618C")]
		public static bool CheckHelmetHide(uint dataId)
		{
			return default(bool);
		}

		// Token: 0x0600A436 RID: 42038 RVA: 0x0002B938 File Offset: 0x00029B38
		[Token(Token = "0x600A436")]
		[Address(RVA = "0x2356354", Offset = "0x2356354", VA = "0x7BBCB56354")]
		public static bool CheckVestHide(uint dataId)
		{
			return default(bool);
		}

		// Token: 0x0600A437 RID: 42039 RVA: 0x0002B950 File Offset: 0x00029B50
		[Token(Token = "0x600A437")]
		[Address(RVA = "0x235647C", Offset = "0x235647C", VA = "0x7BBCB5647C")]
		public static bool CheckHasFace(uint dataId)
		{
			return default(bool);
		}

		// Token: 0x0600A438 RID: 42040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A438")]
		[Address(RVA = "0x23565A4", Offset = "0x23565A4", VA = "0x7BBCB565A4")]
		public void LocalSaveClothData(AvatarWardrobeData data)
		{
		}

		// Token: 0x0600A439 RID: 42041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A439")]
		[Address(RVA = "0x23566C0", Offset = "0x23566C0", VA = "0x7BBCB566C0")]
		public void LocalSaveClothData(uint avatarID, AvatarWardrobeData data)
		{
		}

		// Token: 0x0600A43A RID: 42042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A43A")]
		[Address(RVA = "0x2356804", Offset = "0x2356804", VA = "0x7BBCB56804")]
		public void LocalClearClothData(uint avatarID)
		{
		}

		// Token: 0x0600A43B RID: 42043 RVA: 0x0002B968 File Offset: 0x00029B68
		[Token(Token = "0x600A43B")]
		[Address(RVA = "0x23568C4", Offset = "0x23568C4", VA = "0x7BBCB568C4")]
		public bool CheckClothIsEquipInAvatar(uint clothID)
		{
			return default(bool);
		}

		// Token: 0x0600A43C RID: 42044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A43C")]
		[Address(RVA = "0x2356BBC", Offset = "0x2356BBC", VA = "0x7BBCB56BBC")]
		public void RequestChooseAvatar()
		{
		}

		// Token: 0x0600A43D RID: 42045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A43D")]
		[Address(RVA = "0x2356BC0", Offset = "0x2356BC0", VA = "0x7BBCB56BC0")]
		public void RequestChooseCloth(uint avatarID = 0U, bool cloneBeforeRequest = true, bool refreshState = false)
		{
		}

		// Token: 0x0600A43E RID: 42046 RVA: 0x0002B980 File Offset: 0x00029B80
		[Token(Token = "0x600A43E")]
		[Address(RVA = "0x235716C", Offset = "0x235716C", VA = "0x7BBCB5716C")]
		private bool CheckClothesCanChange(uint[] clothes)
		{
			return default(bool);
		}

		// Token: 0x0600A43F RID: 42047 RVA: 0x0002B998 File Offset: 0x00029B98
		[Token(Token = "0x600A43F")]
		[Address(RVA = "0x2357284", Offset = "0x2357284", VA = "0x7BBCB57284")]
		private int GetClothesHighestRankUseLevel(uint[] clothes)
		{
			return 0;
		}

		// Token: 0x0600A440 RID: 42048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A440")]
		[Address(RVA = "0x23575AC", Offset = "0x23575AC", VA = "0x7BBCB575AC")]
		private void SetHighestRankUseLevel(uint clothID, ref int highestRankUseLevel)
		{
		}

		// Token: 0x0600A441 RID: 42049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A441")]
		[Address(RVA = "0x235767C", Offset = "0x235767C", VA = "0x7BBCB5767C")]
		public void CacheAvatarSkinColor(uint avatarID, float color)
		{
		}

		// Token: 0x0600A442 RID: 42050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A442")]
		[Address(RVA = "0x2357688", Offset = "0x2357688", VA = "0x7BBCB57688")]
		public void SendCacheAvatarSkinColor(bool refresh = false)
		{
		}

		// Token: 0x0600A443 RID: 42051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A443")]
		[Address(RVA = "0x23577A8", Offset = "0x23577A8", VA = "0x7BBCB577A8")]
		public void SetAvatarSkinColor(uint avatarID, float color)
		{
		}

		// Token: 0x0600A444 RID: 42052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A444")]
		[Address(RVA = "0x2357300", Offset = "0x2357300", VA = "0x7BBCB57300")]
		private void ShowNotReachRankItemUseLevelTips(int rankLevel)
		{
		}

		// Token: 0x0600A445 RID: 42053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A445")]
		[Address(RVA = "0x2357854", Offset = "0x2357854", VA = "0x7BBCB57854")]
		public Dictionary<uint, UIModelAvatarBase.AvatarData> GetAvatars()
		{
			return null;
		}

		// Token: 0x0600A446 RID: 42054 RVA: 0x0002B9B0 File Offset: 0x00029BB0
		[Token(Token = "0x600A446")]
		[Address(RVA = "0x235785C", Offset = "0x235785C", VA = "0x7BBCB5785C")]
		public bool CanEquipCloth(uint itemId, uint avatarid = 0U)
		{
			return default(bool);
		}

		// Token: 0x0600A447 RID: 42055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A447")]
		[Address(RVA = "0x2357A8C", Offset = "0x2357A8C", VA = "0x7BBCB57A8C")]
		private static void LogRecipeAbReadyError(string s)
		{
		}

		// Token: 0x0600A448 RID: 42056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A448")]
		[Address(RVA = "0x2357AF4", Offset = "0x2357AF4", VA = "0x7BBCB57AF4")]
		private static void LogRecipeAbReadyError(string s, UMATextRecipe recipe)
		{
		}

		// Token: 0x0600A449 RID: 42057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A449")]
		[Address(RVA = "0x2357BA4", Offset = "0x2357BA4", VA = "0x7BBCB57BA4")]
		public static void GetRecipeResIDNotDownload(string recipe, ref List<ResourceID> not_download_res_list, bool skipDownloadedCheck = false)
		{
		}

		// Token: 0x0600A44A RID: 42058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A44A")]
		[Address(RVA = "0x2357CB8", Offset = "0x2357CB8", VA = "0x7BBCB57CB8")]
		public static void GetRecipeResIDNotDownload(UMATextRecipe recipe, ref List<ResourceID> not_download_res_list, bool skipDownloadedCheck = false)
		{
		}

		// Token: 0x0600A44B RID: 42059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A44B")]
		[Address(RVA = "0x23581EC", Offset = "0x23581EC", VA = "0x7BBCB581EC")]
		public static void GetRecipeResIDNotDownload(UmaRecipeSimple recipe, ref List<ResourceID> not_download_res_list, bool skipDownloadedCheck = false)
		{
		}

		// Token: 0x0600A44C RID: 42060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A44C")]
		[Address(RVA = "0x2358538", Offset = "0x2358538", VA = "0x7BBCB58538")]
		public static void LoadRecipeAssets(string recipe)
		{
		}

		// Token: 0x0600A44D RID: 42061 RVA: 0x0002B9C8 File Offset: 0x00029BC8
		[Token(Token = "0x600A44D")]
		[Address(RVA = "0x23588D8", Offset = "0x23588D8", VA = "0x7BBCB588D8")]
		public static bool IsRecipeAbReady(uint itemID, uint avatarId, bool isFemale, bool highquality, bool checkLoad, [Optional] UMAContextSimple context)
		{
			return default(bool);
		}

		// Token: 0x0600A44E RID: 42062 RVA: 0x0002B9E0 File Offset: 0x00029BE0
		[Token(Token = "0x600A44E")]
		[Address(RVA = "0x2358AA0", Offset = "0x2358AA0", VA = "0x7BBCB58AA0")]
		public static bool IsRecipeAbReady(string recipe, bool checkLoad = false, bool forAsync = false, [Optional] UMAContextSimple context)
		{
			return default(bool);
		}

		// Token: 0x0600A44F RID: 42063 RVA: 0x0002B9F8 File Offset: 0x00029BF8
		[Token(Token = "0x600A44F")]
		[Address(RVA = "0x2358D7C", Offset = "0x2358D7C", VA = "0x7BBCB58D7C")]
		private static bool CheckRecipeAbReady(UMAContextSimple context, UMATextRecipe recipe, bool checkLoad = false)
		{
			return default(bool);
		}

		// Token: 0x0600A450 RID: 42064 RVA: 0x0002BA10 File Offset: 0x00029C10
		[Token(Token = "0x600A450")]
		private static UIModelAvatar.AbReadyState CheckSlotOrOverlayAbState<T>(UMAContextSimple context, string name, bool checkLoad) where T : UnityEngine.Object
		{
			return UIModelAvatar.AbReadyState.NoResId;
		}

		// Token: 0x0600A451 RID: 42065 RVA: 0x0002BA28 File Offset: 0x00029C28
		[Token(Token = "0x600A451")]
		[Address(RVA = "0x235907C", Offset = "0x235907C", VA = "0x7BBCB5907C")]
		private static bool CheckRecipeAbReady(UMAContextSimple context, UmaRecipeSimple recipe, bool checkLoad = false, bool forAsync = false)
		{
			return default(bool);
		}

		// Token: 0x0600A452 RID: 42066 RVA: 0x0002BA40 File Offset: 0x00029C40
		[Token(Token = "0x600A452")]
		[Address(RVA = "0x2359740", Offset = "0x2359740", VA = "0x7BBCB59740")]
		private static bool IsSlotOverlayInSameAb(int slotHash, int overlayHash)
		{
			return default(bool);
		}

		// Token: 0x0600A453 RID: 42067 RVA: 0x0002BA58 File Offset: 0x00029C58
		[Token(Token = "0x600A453")]
		[Address(RVA = "0x2359500", Offset = "0x2359500", VA = "0x7BBCB59500")]
		private static UIModelAvatar.AbReadyState CheckSlotOrOverlayAbState(UMAContextSimple context, int hash, bool isSlot, bool checkLoad)
		{
			return UIModelAvatar.AbReadyState.NoResId;
		}

		// Token: 0x0600A454 RID: 42068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A454")]
		[Address(RVA = "0x2359830", Offset = "0x2359830", VA = "0x7BBCB59830")]
		public void AvatarPlayEnterTeamAnim()
		{
		}

		// Token: 0x0600A455 RID: 42069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A455")]
		[Address(RVA = "0x2359998", Offset = "0x2359998", VA = "0x7BBCB59998")]
		public void AvatarPlayEnterTeamAnim(UIMaleAvatar avatar, bool isFemale, uint[] clothes)
		{
		}

		// Token: 0x0600A456 RID: 42070 RVA: 0x0002BA70 File Offset: 0x00029C70
		[Token(Token = "0x600A456")]
		[Address(RVA = "0x2359B54", Offset = "0x2359B54", VA = "0x7BBCB59B54")]
		private bool PlayEnterTeamAnimByAvatarWardrobeData(UIMaleAvatar avatar, AvatarWardrobeData clothData, bool isFemale)
		{
			return default(bool);
		}

		// Token: 0x0600A457 RID: 42071 RVA: 0x0002BA88 File Offset: 0x00029C88
		[Token(Token = "0x600A457")]
		[Address(RVA = "0x2359CE0", Offset = "0x2359CE0", VA = "0x7BBCB59CE0")]
		public uint GetEffectTeamAnimClothId()
		{
			return 0U;
		}

		// Token: 0x0600A458 RID: 42072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A458")]
		[Address(RVA = "0x2359F28", Offset = "0x2359F28", VA = "0x7BBCB59F28")]
		public UIModelAvatar()
		{
		}

		// Token: 0x0400AA53 RID: 43603
		[Token(Token = "0x400AA53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<string, List<string>> m_TempDict;

		// Token: 0x0400AA54 RID: 43604
		[Token(Token = "0x400AA54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Dictionary<string, bool> CachedRecipeReadyList;

		// Token: 0x0400AA55 RID: 43605
		[Token(Token = "0x400AA55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Dictionary<UIModelAvatarBase.EGenderType, List<CSSharedAvatarData>> m_DictBackpackAvatar;

		// Token: 0x0400AA56 RID: 43606
		[Token(Token = "0x400AA56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<UIModelAvatarBase.EWardrobeType, List<InventoryClothInfo>> m_DictBackpackCloth;

		// Token: 0x0400AA57 RID: 43607
		[Token(Token = "0x400AA57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<uint, UIModelAvatarBase.AvatarData> m_Avatars;

		// Token: 0x0400AA58 RID: 43608
		[Token(Token = "0x400AA58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private UIModelAvatarBase.AvatarData m_CurrentAvatar;

		// Token: 0x0400AA59 RID: 43609
		[Token(Token = "0x400AA59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private UIModelAvatarBase.AvatarData m_CachedAvatar;

		// Token: 0x0400AA5A RID: 43610
		[Token(Token = "0x400AA5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool m_gunHasRefresh;

		// Token: 0x0400AA5B RID: 43611
		[Token(Token = "0x400AA5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private uint m_FemaleDefaultModifyId;

		// Token: 0x0400AA5C RID: 43612
		[Token(Token = "0x400AA5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private uint m_MaleDefaultModifyId;

		// Token: 0x0400AA5D RID: 43613
		[Token(Token = "0x400AA5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private uint m_CacheAvatarId;

		// Token: 0x0400AA5E RID: 43614
		[Token(Token = "0x400AA5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float m_CacheAvatarColor;

		// Token: 0x0400AA5F RID: 43615
		[Token(Token = "0x400AA5F")]
		private const bool ChecksOverlayInSlotBeforeResource = true;

		// Token: 0x02001D6B RID: 7531
		[Token(Token = "0x2001D6B")]
		private enum AbReadyState
		{
			// Token: 0x0400AA61 RID: 43617
			[Token(Token = "0x400AA61")]
			NoResId,
			// Token: 0x0400AA62 RID: 43618
			[Token(Token = "0x400AA62")]
			NoAb,
			// Token: 0x0400AA63 RID: 43619
			[Token(Token = "0x400AA63")]
			AbReady,
			// Token: 0x0400AA64 RID: 43620
			[Token(Token = "0x400AA64")]
			AbNotReady,
			// Token: 0x0400AA65 RID: 43621
			[Token(Token = "0x400AA65")]
			LoadFailed
		}

		// Token: 0x02001D6C RID: 7532
		[Token(Token = "0x2001D6C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBD24", Offset = "0x10FBD24")]
		private sealed class <>c__DisplayClass50_0
		{
			// Token: 0x0600A45A RID: 42074 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A45A")]
			[Address(RVA = "0x235715C", Offset = "0x235715C", VA = "0x7BBCB5715C")]
			public <>c__DisplayClass50_0()
			{
			}

			// Token: 0x0400AA66 RID: 43622
			[Token(Token = "0x400AA66")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public uint avatarID;

			// Token: 0x0400AA67 RID: 43623
			[Token(Token = "0x400AA67")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UIModelAvatar <>4__this;

			// Token: 0x0400AA68 RID: 43624
			[Token(Token = "0x400AA68")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool refreshState;

			// Token: 0x0400AA69 RID: 43625
			[Token(Token = "0x400AA69")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
			public bool cloneBeforeRequest;
		}

		// Token: 0x02001D6D RID: 7533
		[Token(Token = "0x2001D6D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBD34", Offset = "0x10FBD34")]
		private sealed class <>c__DisplayClass50_1
		{
			// Token: 0x0600A45B RID: 42075 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A45B")]
			[Address(RVA = "0x2357164", Offset = "0x2357164", VA = "0x7BBCB57164")]
			public <>c__DisplayClass50_1()
			{
			}

			// Token: 0x0600A45C RID: 42076 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A45C")]
			[Address(RVA = "0x235A118", Offset = "0x235A118", VA = "0x7BBCB5A118")]
			internal void <RequestChooseCloth>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400AA6A RID: 43626
			[Token(Token = "0x400AA6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CSChangeClothesReq req;

			// Token: 0x0400AA6B RID: 43627
			[Token(Token = "0x400AA6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int highestRankUseLevel;

			// Token: 0x0400AA6C RID: 43628
			[Token(Token = "0x400AA6C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UIModelAvatar.<>c__DisplayClass50_0 CS$<>8__locals1;
		}
	}
}
