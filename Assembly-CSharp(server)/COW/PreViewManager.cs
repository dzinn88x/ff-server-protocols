using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001296 RID: 4758
	[Token(Token = "0x2001296")]
	public class PreViewManager : SingletonModule<PreViewManager>
	{
		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x060049A8 RID: 18856 RVA: 0x00016410 File Offset: 0x00014610
		// (set) Token: 0x060049A9 RID: 18857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700083C")]
		public uint CustomShowAvatarF
		{
			[Token(Token = "0x60049A8")]
			[Address(RVA = "0x1F003DC", Offset = "0x1F003DC", VA = "0x7BBC7003DC")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60049A9")]
			[Address(RVA = "0x1F003E4", Offset = "0x1F003E4", VA = "0x7BBC7003E4")]
			set
			{
			}
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x060049AA RID: 18858 RVA: 0x00016428 File Offset: 0x00014628
		// (set) Token: 0x060049AB RID: 18859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700083D")]
		public uint CustomShowAvatarM
		{
			[Token(Token = "0x60049AA")]
			[Address(RVA = "0x1F003EC", Offset = "0x1F003EC", VA = "0x7BBC7003EC")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60049AB")]
			[Address(RVA = "0x1F003F4", Offset = "0x1F003F4", VA = "0x7BBC7003F4")]
			set
			{
			}
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x060049AC RID: 18860 RVA: 0x00016440 File Offset: 0x00014640
		// (set) Token: 0x060049AD RID: 18861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700083E")]
		public bool IgnoreManualChange
		{
			[Token(Token = "0x60049AC")]
			[Address(RVA = "0x1F003FC", Offset = "0x1F003FC", VA = "0x7BBC7003FC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DC60", Offset = "0x113DC60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60049AD")]
			[Address(RVA = "0x1F00404", Offset = "0x1F00404", VA = "0x7BBC700404")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DC70", Offset = "0x113DC70")]
			set
			{
			}
		}

		// Token: 0x060049AE RID: 18862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049AE")]
		[Address(RVA = "0x1F00410", Offset = "0x1F00410", VA = "0x7BBC700410")]
		public void SetWeaponId(uint id)
		{
		}

		// Token: 0x060049AF RID: 18863 RVA: 0x00016458 File Offset: 0x00014658
		[Token(Token = "0x60049AF")]
		[Address(RVA = "0x1F00418", Offset = "0x1F00418", VA = "0x7BBC700418")]
		public uint GetWeaponId()
		{
			return 0U;
		}

		// Token: 0x060049B0 RID: 18864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049B0")]
		[Address(RVA = "0x1F00420", Offset = "0x1F00420", VA = "0x7BBC700420", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x060049B1 RID: 18865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049B1")]
		[Address(RVA = "0x1F00648", Offset = "0x1F00648", VA = "0x7BBC700648")]
		public void SetPreviewMoveBg()
		{
		}

		// Token: 0x060049B2 RID: 18866 RVA: 0x00016470 File Offset: 0x00014670
		[Token(Token = "0x60049B2")]
		[Address(RVA = "0x1F00848", Offset = "0x1F00848", VA = "0x7BBC700848")]
		public EFrontendUIType GetPreviewUIType()
		{
			return EFrontendUIType.Lobby;
		}

		// Token: 0x060049B3 RID: 18867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049B3")]
		[Address(RVA = "0x1F007E4", Offset = "0x1F007E4", VA = "0x7BBC7007E4")]
		private Transform FindBGUIRoot()
		{
			return null;
		}

		// Token: 0x060049B4 RID: 18868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049B4")]
		[Address(RVA = "0x1F00850", Offset = "0x1F00850", VA = "0x7BBC700850")]
		public void SetGroundShadowPos(Vector3 pos)
		{
		}

		// Token: 0x060049B5 RID: 18869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049B5")]
		[Address(RVA = "0x1F00934", Offset = "0x1F00934", VA = "0x7BBC700934", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x060049B6 RID: 18870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049B6")]
		[Address(RVA = "0x1F011D0", Offset = "0x1F011D0", VA = "0x7BBC7011D0")]
		private void InitView()
		{
		}

		// Token: 0x060049B7 RID: 18871 RVA: 0x00016488 File Offset: 0x00014688
		[Token(Token = "0x60049B7")]
		[Address(RVA = "0x1F0161C", Offset = "0x1F0161C", VA = "0x7BBC70161C")]
		public EFrontendUIType GetCurrentShowUIType()
		{
			return EFrontendUIType.Lobby;
		}

		// Token: 0x060049B8 RID: 18872 RVA: 0x000164A0 File Offset: 0x000146A0
		[Token(Token = "0x60049B8")]
		[Address(RVA = "0x1F01624", Offset = "0x1F01624", VA = "0x7BBC701624")]
		public bool HasCreate()
		{
			return default(bool);
		}

		// Token: 0x060049B9 RID: 18873 RVA: 0x000164B8 File Offset: 0x000146B8
		[Token(Token = "0x60049B9")]
		[Address(RVA = "0x1F0162C", Offset = "0x1F0162C", VA = "0x7BBC70162C")]
		public bool IsPreviewing()
		{
			return default(bool);
		}

		// Token: 0x060049BA RID: 18874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049BA")]
		[Address(RVA = "0x1F0169C", Offset = "0x1F0169C", VA = "0x7BBC70169C")]
		public void SetMixCameraChangeSceneBg()
		{
		}

		// Token: 0x060049BB RID: 18875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049BB")]
		[Address(RVA = "0x1F01894", Offset = "0x1F01894", VA = "0x7BBC701894")]
		public void ResetMixCameraSceneBg()
		{
		}

		// Token: 0x060049BC RID: 18876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049BC")]
		[Address(RVA = "0x1F01A08", Offset = "0x1F01A08", VA = "0x7BBC701A08")]
		public void OpenPreview(EFrontendUIType uitype)
		{
		}

		// Token: 0x060049BD RID: 18877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049BD")]
		[Address(RVA = "0x1F032B8", Offset = "0x1F032B8", VA = "0x7BBC7032B8")]
		public void ChangeMixCameraDepth(int depth)
		{
		}

		// Token: 0x060049BE RID: 18878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049BE")]
		[Address(RVA = "0x1F033A4", Offset = "0x1F033A4", VA = "0x7BBC7033A4")]
		public void ResetPreview()
		{
		}

		// Token: 0x060049BF RID: 18879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049BF")]
		[Address(RVA = "0x1F033AC", Offset = "0x1F033AC", VA = "0x7BBC7033AC")]
		public void ForceClearPanel()
		{
		}

		// Token: 0x060049C0 RID: 18880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049C0")]
		[Address(RVA = "0x1F03444", Offset = "0x1F03444", VA = "0x7BBC703444")]
		public void ClosePreview(EFrontendUIType uitype)
		{
		}

		// Token: 0x060049C1 RID: 18881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049C1")]
		[Address(RVA = "0x1F031BC", Offset = "0x1F031BC", VA = "0x7BBC7031BC")]
		private void ModifyItemCamera()
		{
		}

		// Token: 0x060049C2 RID: 18882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049C2")]
		[Address(RVA = "0x1F03C18", Offset = "0x1F03C18", VA = "0x7BBC703C18")]
		public void SetPreviewCgShow(bool flag)
		{
		}

		// Token: 0x060049C3 RID: 18883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049C3")]
		[Address(RVA = "0x1F03F7C", Offset = "0x1F03F7C", VA = "0x7BBC703F7C")]
		public void ForceRefreshShadow([Optional] UIMaleAvatar ava)
		{
		}

		// Token: 0x060049C4 RID: 18884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049C4")]
		[Address(RVA = "0x1F041D8", Offset = "0x1F041D8", VA = "0x7BBC7041D8")]
		public void ShowItemByIdList(List<uint> idlist, bool special = false, ECollectionLevel level = ECollectionLevel.Lv3, bool isShow = true, [Optional] ShowBoostAvatarParams showBoostAvatarParams, bool showInstallmentInfo = false)
		{
		}

		// Token: 0x060049C5 RID: 18885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049C5")]
		[Address(RVA = "0x1F057A0", Offset = "0x1F057A0", VA = "0x7BBC7057A0")]
		public void ShowBoostAvatar(uint itemID, ShowBoostAvatarParams showBoostAvatarParams)
		{
		}

		// Token: 0x060049C6 RID: 18886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049C6")]
		[Address(RVA = "0x1F0601C", Offset = "0x1F0601C", VA = "0x7BBC70601C")]
		private void ChangePreviewCameraEnable(PreviewCameraMove mixcameraComp, PreviewCameraMove avatarcameraComp, bool enabled)
		{
		}

		// Token: 0x060049C7 RID: 18887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049C7")]
		[Address(RVA = "0x1F0609C", Offset = "0x1F0609C", VA = "0x7BBC70609C")]
		public void StopAvatarAnim()
		{
		}

		// Token: 0x060049C8 RID: 18888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049C8")]
		[Address(RVA = "0x1F038C0", Offset = "0x1F038C0", VA = "0x7BBC7038C0")]
		public void ResetCamera()
		{
		}

		// Token: 0x060049C9 RID: 18889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049C9")]
		[Address(RVA = "0x1F05618", Offset = "0x1F05618", VA = "0x7BBC705618")]
		private void ShowHairStyle(CSSharedItemData item)
		{
		}

		// Token: 0x060049CA RID: 18890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049CA")]
		[Address(RVA = "0x1F062D8", Offset = "0x1F062D8", VA = "0x7BBC7062D8")]
		public void ShowZoomItemById(uint id)
		{
		}

		// Token: 0x060049CB RID: 18891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049CB")]
		[Address(RVA = "0x1F06D98", Offset = "0x1F06D98", VA = "0x7BBC706D98")]
		public void EnablePetRotate(bool enabled)
		{
		}

		// Token: 0x060049CC RID: 18892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049CC")]
		[Address(RVA = "0x1F07198", Offset = "0x1F07198", VA = "0x7BBC707198")]
		public void ShowPreview(BaseItemInfo data, EInventory.AwardType award_type, bool isShow = true, bool isShowOwned = true)
		{
		}

		// Token: 0x060049CD RID: 18893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049CD")]
		[Address(RVA = "0x1F08524", Offset = "0x1F08524", VA = "0x7BBC708524")]
		public void ShowPreview(BundleShowData bundleShowData, bool isShow = true, bool isShowOwned = true)
		{
		}

		// Token: 0x060049CE RID: 18894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049CE")]
		[Address(RVA = "0x1F085D8", Offset = "0x1F085D8", VA = "0x7BBC7085D8")]
		public void SetTreasureBoxProbabilityState(bool show, uint itemID)
		{
		}

		// Token: 0x060049CF RID: 18895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049CF")]
		[Address(RVA = "0x1F07AC4", Offset = "0x1F07AC4", VA = "0x7BBC707AC4")]
		public void ShowPriviewById(uint id, bool isShow = true, bool isShowOwned = true, [Optional] FullScreenAnimParams animdata, [Optional] ShowBoostAvatarParams showBoostAvatarParams, bool showInstallmentInfo = false)
		{
		}

		// Token: 0x060049D0 RID: 18896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049D0")]
		[Address(RVA = "0x1F0AD1C", Offset = "0x1F0AD1C", VA = "0x7BBC70AD1C")]
		public void CheckAndPlayFacialAnim(CSSharedItemData data)
		{
		}

		// Token: 0x060049D1 RID: 18897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049D1")]
		[Address(RVA = "0x1F0A068", Offset = "0x1F0A068", VA = "0x7BBC70A068")]
		public void ShowPet(CSSharedItemData itemTemp)
		{
		}

		// Token: 0x060049D2 RID: 18898 RVA: 0x000164D0 File Offset: 0x000146D0
		[Token(Token = "0x60049D2")]
		[Address(RVA = "0x1F0BC40", Offset = "0x1F0BC40", VA = "0x7BBC70BC40")]
		public uint LimitCardId2ItemId(uint cardid)
		{
			return 0U;
		}

		// Token: 0x060049D3 RID: 18899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049D3")]
		[Address(RVA = "0x1F0BD4C", Offset = "0x1F0BD4C", VA = "0x7BBC70BD4C")]
		public void HideItemDesc()
		{
		}

		// Token: 0x060049D4 RID: 18900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049D4")]
		[Address(RVA = "0x1F08D44", Offset = "0x1F08D44", VA = "0x7BBC708D44")]
		private void SetBundleDescription(List<BaseItemInfo> previewUIList, int type, bool isShowOwned, [Optional] ShowBoostAvatarParams showBoostAvatarParams)
		{
		}

		// Token: 0x060049D5 RID: 18901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049D5")]
		[Address(RVA = "0x1F086AC", Offset = "0x1F086AC", VA = "0x7BBC7086AC")]
		public void SetCommonDescription(uint id)
		{
		}

		// Token: 0x060049D6 RID: 18902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049D6")]
		[Address(RVA = "0x1F0BE04", Offset = "0x1F0BE04", VA = "0x7BBC70BE04")]
		public void RefreshSingleDesc(uint id)
		{
		}

		// Token: 0x060049D7 RID: 18903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049D7")]
		[Address(RVA = "0x1F0BFB8", Offset = "0x1F0BFB8", VA = "0x7BBC70BFB8")]
		public void ShowIPTag()
		{
		}

		// Token: 0x060049D8 RID: 18904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049D8")]
		[Address(RVA = "0x1F05D84", Offset = "0x1F05D84", VA = "0x7BBC705D84")]
		public void ShowIPTag(uint id)
		{
		}

		// Token: 0x060049D9 RID: 18905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049D9")]
		[Address(RVA = "0x1F05BF4", Offset = "0x1F05BF4", VA = "0x7BBC705BF4")]
		public void ShowInstallmentInfo(bool show, uint id)
		{
		}

		// Token: 0x060049DA RID: 18906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049DA")]
		[Address(RVA = "0x1F0C054", Offset = "0x1F0C054", VA = "0x7BBC70C054")]
		public void SetCommonPanel(int width, bool left, Vector3 offset, bool needZoom = false)
		{
		}

		// Token: 0x060049DB RID: 18907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049DB")]
		[Address(RVA = "0x1F0C158", Offset = "0x1F0C158", VA = "0x7BBC70C158")]
		public void SetPreivewPanel(Vector3 left, Vector3 right, bool needZoom)
		{
		}

		// Token: 0x060049DC RID: 18908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049DC")]
		[Address(RVA = "0x1F09FB8", Offset = "0x1F09FB8", VA = "0x7BBC709FB8")]
		public void SetHotFixDownload(bool isneeddownload)
		{
		}

		// Token: 0x060049DD RID: 18909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049DD")]
		[Address(RVA = "0x1F0C264", Offset = "0x1F0C264", VA = "0x7BBC70C264")]
		public void ShowForgeAwardBtn(bool show, ResourceID iconRes)
		{
		}

		// Token: 0x060049DE RID: 18910 RVA: 0x000164E8 File Offset: 0x000146E8
		[Token(Token = "0x60049DE")]
		[Address(RVA = "0x1F0C31C", Offset = "0x1F0C31C", VA = "0x7BBC70C31C")]
		public Vector2 GetDownLoadBtnWorldPos()
		{
			return default(Vector2);
		}

		// Token: 0x060049DF RID: 18911 RVA: 0x00016500 File Offset: 0x00014700
		[Token(Token = "0x60049DF")]
		[Address(RVA = "0x1F0C3DC", Offset = "0x1F0C3DC", VA = "0x7BBC70C3DC")]
		public Vector2 GetItemDescWorldPos()
		{
			return default(Vector2);
		}

		// Token: 0x060049E0 RID: 18912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049E0")]
		[Address(RVA = "0x1F030E4", Offset = "0x1F030E4", VA = "0x7BBC7030E4")]
		public void SetCommonItemCameratrans(Vector3 trans, Quaternion rotate)
		{
		}

		// Token: 0x060049E1 RID: 18913 RVA: 0x00016518 File Offset: 0x00014718
		[Token(Token = "0x60049E1")]
		[Address(RVA = "0x1F0C49C", Offset = "0x1F0C49C", VA = "0x7BBC70C49C")]
		public uint GetPreviewAvatarId(uint clothesID)
		{
			return 0U;
		}

		// Token: 0x060049E2 RID: 18914 RVA: 0x00016530 File Offset: 0x00014730
		[Token(Token = "0x60049E2")]
		[Address(RVA = "0x1F0C55C", Offset = "0x1F0C55C", VA = "0x7BBC70C55C")]
		public uint GetPreviewAvatarId(AvatarWardrobeData wData, uint bundleShowFemale, uint bundleShowMale)
		{
			return 0U;
		}

		// Token: 0x060049E3 RID: 18915 RVA: 0x00016548 File Offset: 0x00014748
		[Token(Token = "0x60049E3")]
		[Address(RVA = "0x1F0C800", Offset = "0x1F0C800", VA = "0x7BBC70C800")]
		public uint GetPreviewAvatarId(EFrontendUIType type, uint bundleShowFemale, uint bundleShowMale)
		{
			return 0U;
		}

		// Token: 0x060049E4 RID: 18916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049E4")]
		[Address(RVA = "0x1F09E88", Offset = "0x1F09E88", VA = "0x7BBC709E88")]
		private void OnClothesItemSelect(uint clothesID, out List<uint> preview3DList, out bool isSpecial)
		{
		}

		// Token: 0x060049E5 RID: 18917 RVA: 0x00016560 File Offset: 0x00014760
		[Token(Token = "0x60049E5")]
		[Address(RVA = "0x1F0C8C0", Offset = "0x1F0C8C0", VA = "0x7BBC70C8C0")]
		public uint GetBundleNoAvatarShowId(uint bundleID)
		{
			return 0U;
		}

		// Token: 0x060049E6 RID: 18918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049E6")]
		[Address(RVA = "0x1F0877C", Offset = "0x1F0877C", VA = "0x7BBC70877C")]
		public void OnBundleItemSelect(uint bundleID, List<BundleShowData> bundleList, out List<BaseItemInfo> previewUIList, out List<uint> preview3DList, out bool isSpecial)
		{
		}

		// Token: 0x060049E7 RID: 18919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049E7")]
		[Address(RVA = "0x1F08E7C", Offset = "0x1F08E7C", VA = "0x7BBC708E7C")]
		public void OnOptionalBundleItemSelect(uint optionalBundleID, List<OptionalBundleShowData> optionalBundleList, out List<BaseItemInfo> previewUIList, out List<uint> preview3DList, out bool isSpecial)
		{
		}

		// Token: 0x060049E8 RID: 18920 RVA: 0x00016578 File Offset: 0x00014778
		[Token(Token = "0x60049E8")]
		[Address(RVA = "0x1F0D310", Offset = "0x1F0D310", VA = "0x7BBC70D310")]
		public bool IsSpecialPreviewBundle(uint itemID, bool checkOwned = false)
		{
			return default(bool);
		}

		// Token: 0x060049E9 RID: 18921 RVA: 0x00016590 File Offset: 0x00014790
		[Token(Token = "0x60049E9")]
		[Address(RVA = "0x1F0CA34", Offset = "0x1F0CA34", VA = "0x7BBC70CA34")]
		public bool IsSpecialPreviewBundle(List<BundleShowData> bundleList, bool checkOwned = false)
		{
			return default(bool);
		}

		// Token: 0x060049EA RID: 18922 RVA: 0x000165A8 File Offset: 0x000147A8
		[Token(Token = "0x60049EA")]
		[Address(RVA = "0x1F0D428", Offset = "0x1F0D428", VA = "0x7BBC70D428")]
		public bool IsSpecialPreviewOptionalBundle(uint itemID)
		{
			return default(bool);
		}

		// Token: 0x060049EB RID: 18923 RVA: 0x000165C0 File Offset: 0x000147C0
		[Token(Token = "0x60049EB")]
		[Address(RVA = "0x1F0CF64", Offset = "0x1F0CF64", VA = "0x7BBC70CF64")]
		public bool IsSpecialPreviewOptionalBundle(List<OptionalBundleShowData> optionalBundleList)
		{
			return default(bool);
		}

		// Token: 0x060049EC RID: 18924 RVA: 0x000165D8 File Offset: 0x000147D8
		[Token(Token = "0x60049EC")]
		[Address(RVA = "0x1F0D530", Offset = "0x1F0D530", VA = "0x7BBC70D530")]
		public bool IsSpecialTreasureBox(uint itemID)
		{
			return default(bool);
		}

		// Token: 0x060049ED RID: 18925 RVA: 0x000165F0 File Offset: 0x000147F0
		[Token(Token = "0x60049ED")]
		[Address(RVA = "0x1F0D638", Offset = "0x1F0D638", VA = "0x7BBC70D638")]
		public bool IsSpecialTreasureBox(List<TreasureBoxShowData> boxList)
		{
			return default(bool);
		}

		// Token: 0x060049EE RID: 18926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049EE")]
		[Address(RVA = "0x1F0CE50", Offset = "0x1F0CE50", VA = "0x7BBC70CE50")]
		private void ShowSpecAward(EInventory.AwardType awardtype, bool refreshDesc = true)
		{
		}

		// Token: 0x060049EF RID: 18927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049EF")]
		[Address(RVA = "0x1F097C4", Offset = "0x1F097C4", VA = "0x7BBC7097C4")]
		public void OnBoxItemBtnSelect(uint boxID, List<TreasureBoxShowData> boxList, out List<BaseItemInfo> previewUIList, out List<uint> preview3DList, out bool isSpecial)
		{
		}

		// Token: 0x060049F0 RID: 18928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049F0")]
		[Address(RVA = "0x1F0AEC0", Offset = "0x1F0AEC0", VA = "0x7BBC70AEC0")]
		public void ShowPetAvatar(uint pet_id)
		{
		}

		// Token: 0x060049F1 RID: 18929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049F1")]
		[Address(RVA = "0x1F0E7E4", Offset = "0x1F0E7E4", VA = "0x7BBC70E7E4")]
		public void Set3DAvatrTouchEnable(bool flag)
		{
		}

		// Token: 0x060049F2 RID: 18930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049F2")]
		[Address(RVA = "0x1F0E970", Offset = "0x1F0E970", VA = "0x7BBC70E970")]
		public void Set3dItemTouchEnable(bool flag)
		{
		}

		// Token: 0x060049F3 RID: 18931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049F3")]
		[Address(RVA = "0x1F0EA60", Offset = "0x1F0EA60", VA = "0x7BBC70EA60")]
		public UIPetAvatar GetPetAvatar()
		{
			return null;
		}

		// Token: 0x060049F4 RID: 18932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049F4")]
		[Address(RVA = "0x1F04A14", Offset = "0x1F04A14", VA = "0x7BBC704A14")]
		public void ShowAvatar(List<uint> idlist, PreViewManager.AvatarType type = PreViewManager.AvatarType.localAvatar, bool playanim = true, uint skinWeapon = 0U)
		{
		}

		// Token: 0x060049F5 RID: 18933 RVA: 0x00016608 File Offset: 0x00014808
		[Token(Token = "0x60049F5")]
		[Address(RVA = "0x1F0309C", Offset = "0x1F0309C", VA = "0x7BBC70309C")]
		private bool IsShowShadowUIType()
		{
			return default(bool);
		}

		// Token: 0x060049F6 RID: 18934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049F6")]
		[Address(RVA = "0x1F0EFD0", Offset = "0x1F0EFD0", VA = "0x7BBC70EFD0")]
		public void ShowAvatarWithCurrentCloth(PreViewManager.AvatarType type = PreViewManager.AvatarType.localAvatar)
		{
		}

		// Token: 0x060049F7 RID: 18935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049F7")]
		[Address(RVA = "0x1F0EA68", Offset = "0x1F0EA68", VA = "0x7BBC70EA68")]
		private void PreviewDefaultClothes(List<uint> idlist, PreViewManager.Cameratype type, UIMaleAvatar avatarmodel, bool playanim)
		{
		}

		// Token: 0x060049F8 RID: 18936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049F8")]
		[Address(RVA = "0x1F0F5E0", Offset = "0x1F0F5E0", VA = "0x7BBC70F5E0")]
		public UIMaleAvatar GetPreviewCachedAvatar()
		{
			return null;
		}

		// Token: 0x060049F9 RID: 18937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049F9")]
		[Address(RVA = "0x1F03A5C", Offset = "0x1F03A5C", VA = "0x7BBC703A5C")]
		public void ClearCachedAvatar()
		{
		}

		// Token: 0x060049FA RID: 18938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049FA")]
		[Address(RVA = "0x1F0ED50", Offset = "0x1F0ED50", VA = "0x7BBC70ED50")]
		private void CreatePreviewAvatarWithNoCache(List<uint> idlist)
		{
		}

		// Token: 0x060049FB RID: 18939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049FB")]
		[Address(RVA = "0x1F0F9A8", Offset = "0x1F0F9A8", VA = "0x7BBC70F9A8")]
		public void ForceAutoModifyAvatarPos()
		{
		}

		// Token: 0x060049FC RID: 18940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049FC")]
		[Address(RVA = "0x1F0FC0C", Offset = "0x1F0FC0C", VA = "0x7BBC70FC0C")]
		public void ForceAutoModifyAvatarPos(GameObject go)
		{
		}

		// Token: 0x060049FD RID: 18941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049FD")]
		[Address(RVA = "0x1F0EE78", Offset = "0x1F0EE78", VA = "0x7BBC70EE78")]
		private void CreatePreviewAvatarWithCache(List<uint> idlist)
		{
		}

		// Token: 0x060049FE RID: 18942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049FE")]
		[Address(RVA = "0x1F0FCA8", Offset = "0x1F0FCA8", VA = "0x7BBC70FCA8")]
		public void Show3dHairStyleModel(uint hairid, int level = 3)
		{
		}

		// Token: 0x060049FF RID: 18943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049FF")]
		[Address(RVA = "0x1F03B78", Offset = "0x1F03B78", VA = "0x7BBC703B78")]
		public void ClearItemData()
		{
		}

		// Token: 0x06004A00 RID: 18944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A00")]
		[Address(RVA = "0x1F050A8", Offset = "0x1F050A8", VA = "0x7BBC7050A8")]
		public void Showitems(List<uint> idlist, bool isShow = true, ECollectionLevel level = ECollectionLevel.Lv3)
		{
		}

		// Token: 0x06004A01 RID: 18945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A01")]
		[Address(RVA = "0x1F11764", Offset = "0x1F11764", VA = "0x7BBC711764")]
		public void SkipModelAnim()
		{
		}

		// Token: 0x06004A02 RID: 18946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A02")]
		[Address(RVA = "0x1F10360", Offset = "0x1F10360", VA = "0x7BBC710360")]
		public void Show3DBootyBoxModel(uint id)
		{
		}

		// Token: 0x06004A03 RID: 18947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A03")]
		[Address(RVA = "0x1F06F78", Offset = "0x1F06F78", VA = "0x7BBC706F78")]
		private GameObject LoadReview3dModel(ResourceID model_id)
		{
			return null;
		}

		// Token: 0x06004A04 RID: 18948 RVA: 0x00016620 File Offset: 0x00014820
		[Token(Token = "0x6004A04")]
		[Address(RVA = "0x1F12788", Offset = "0x1F12788", VA = "0x7BBC712788")]
		public Vector3 CalculateCubicBezierPoint(float t, Vector3 p0, Vector3 p1, Vector3 p2)
		{
			return default(Vector3);
		}

		// Token: 0x06004A05 RID: 18949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A05")]
		[Address(RVA = "0x1F1199C", Offset = "0x1F1199C", VA = "0x7BBC71199C")]
		private void CreatePreview3dModel(ResourceID model_id, PreViewManager.CollectionPreviewType type)
		{
		}

		// Token: 0x06004A06 RID: 18950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A06")]
		[Address(RVA = "0x1F12BAC", Offset = "0x1F12BAC", VA = "0x7BBC712BAC")]
		public void ShowAVatarSP(uint avatarid, bool playanim = true)
		{
		}

		// Token: 0x06004A07 RID: 18951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A07")]
		[Address(RVA = "0x1F12E18", Offset = "0x1F12E18", VA = "0x7BBC712E18")]
		public void ShowCachedAvatar(uint avatarid, bool playanim = false)
		{
		}

		// Token: 0x06004A08 RID: 18952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A08")]
		[Address(RVA = "0x1F13084", Offset = "0x1F13084", VA = "0x7BBC713084")]
		public List<uint> GetAvatarClothList()
		{
			return null;
		}

		// Token: 0x06004A09 RID: 18953 RVA: 0x00016638 File Offset: 0x00014838
		[Token(Token = "0x6004A09")]
		[Address(RVA = "0x1F13088", Offset = "0x1F13088", VA = "0x7BBC713088")]
		public UIModelAvatarBase.EClothGenderType GetGenderTypeById(uint id)
		{
			return UIModelAvatarBase.EClothGenderType.GENDERTYPENONE;
		}

		// Token: 0x06004A0A RID: 18954 RVA: 0x00016650 File Offset: 0x00014850
		[Token(Token = "0x6004A0A")]
		[Address(RVA = "0x1F131E0", Offset = "0x1F131E0", VA = "0x7BBC7131E0")]
		public ECollectionLevel GetCollectionLevel()
		{
			return (ECollectionLevel)0;
		}

		// Token: 0x06004A0B RID: 18955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A0B")]
		[Address(RVA = "0x1F131E8", Offset = "0x1F131E8", VA = "0x7BBC7131E8")]
		public void ShowCurrentBackpackModel(uint id)
		{
		}

		// Token: 0x06004A0C RID: 18956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A0C")]
		[Address(RVA = "0x1F0470C", Offset = "0x1F0470C", VA = "0x7BBC70470C")]
		public void Show3DJetpackModel(uint id, ECollectionLevel level)
		{
		}

		// Token: 0x06004A0D RID: 18957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A0D")]
		[Address(RVA = "0x1F10490", Offset = "0x1F10490", VA = "0x7BBC710490")]
		private void SHOW3DParachutecontainer(uint id)
		{
		}

		// Token: 0x06004A0E RID: 18958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A0E")]
		[Address(RVA = "0x1F105C0", Offset = "0x1F105C0", VA = "0x7BBC7105C0")]
		private void SHOW3DSkyBoard(uint id)
		{
		}

		// Token: 0x06004A0F RID: 18959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A0F")]
		[Address(RVA = "0x1F106F0", Offset = "0x1F106F0", VA = "0x7BBC7106F0")]
		private void SHOW3DFlight(uint id)
		{
		}

		// Token: 0x06004A10 RID: 18960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A10")]
		[Address(RVA = "0x1F11634", Offset = "0x1F11634", VA = "0x7BBC711634")]
		private void Show3DRedEnvelope(uint id)
		{
		}

		// Token: 0x06004A11 RID: 18961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A11")]
		[Address(RVA = "0x1F1349C", Offset = "0x1F1349C", VA = "0x7BBC71349C")]
		public void ShowOnly3dWeapon(uint id)
		{
		}

		// Token: 0x06004A12 RID: 18962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A12")]
		[Address(RVA = "0x1F10D0C", Offset = "0x1F10D0C", VA = "0x7BBC710D0C")]
		private void SHOW3DWeaponSkin(uint id, WeaponSkinData lData)
		{
		}

		// Token: 0x06004A13 RID: 18963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A13")]
		[Address(RVA = "0x1F10820", Offset = "0x1F10820", VA = "0x7BBC710820")]
		private void Show3DWeaponSkinWithAvatar(uint id, WeaponSkinData lData)
		{
		}

		// Token: 0x06004A14 RID: 18964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A14")]
		[Address(RVA = "0x1F1424C", Offset = "0x1F1424C", VA = "0x7BBC71424C")]
		public void RefreshWeaponNotificationState()
		{
		}

		// Token: 0x06004A15 RID: 18965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A15")]
		[Address(RVA = "0x1F11464", Offset = "0x1F11464", VA = "0x7BBC711464")]
		public void ShowEmoteWithCurrentAvatar(uint _eid, bool _special = false)
		{
		}

		// Token: 0x06004A16 RID: 18966 RVA: 0x00016668 File Offset: 0x00014868
		[Token(Token = "0x6004A16")]
		[Address(RVA = "0x1F06D4C", Offset = "0x1F06D4C", VA = "0x7BBC706D4C")]
		private PreViewManager.CollectionPreviewType GetWeaponType(WeaponSkinData data)
		{
			return PreViewManager.CollectionPreviewType.BackPack;
		}

		// Token: 0x06004A17 RID: 18967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A17")]
		[Address(RVA = "0x1F144A8", Offset = "0x1F144A8", VA = "0x7BBC7144A8")]
		public void SetGachaZoomBtnVisble(bool isvisble)
		{
		}

		// Token: 0x06004A18 RID: 18968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A18")]
		[Address(RVA = "0x1F14570", Offset = "0x1F14570", VA = "0x7BBC714570")]
		public void SetGachaSwitchVisble(bool flag)
		{
		}

		// Token: 0x06004A19 RID: 18969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A19")]
		[Address(RVA = "0x1F14620", Offset = "0x1F14620", VA = "0x7BBC714620")]
		public void SetZoomBtnVisble(bool showzoomspr, bool showplayspr)
		{
		}

		// Token: 0x06004A1A RID: 18970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A1A")]
		[Address(RVA = "0x1F112A4", Offset = "0x1F112A4", VA = "0x7BBC7112A4")]
		private void SHOW3DVehicleSkin(uint id)
		{
		}

		// Token: 0x06004A1B RID: 18971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A1B")]
		[Address(RVA = "0x1F146D8", Offset = "0x1F146D8", VA = "0x7BBC7146D8")]
		private void AutoSetVehiclePos()
		{
		}

		// Token: 0x06004A1C RID: 18972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A1C")]
		[Address(RVA = "0x1F12AD4", Offset = "0x1F12AD4", VA = "0x7BBC712AD4")]
		private void ReadConfig(ref GameObject go, int collectiontype)
		{
		}

		// Token: 0x06004A1D RID: 18973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A1D")]
		[Address(RVA = "0x1F128E8", Offset = "0x1F128E8", VA = "0x7BBC7128E8")]
		private void SetMiamapBiasNear(GameObject go)
		{
		}

		// Token: 0x06004A1E RID: 18974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A1E")]
		[Address(RVA = "0x1F14700", Offset = "0x1F14700", VA = "0x7BBC714700")]
		private void ReadConfigFromPreview(ref GameObject go, int index, int subindex)
		{
		}

		// Token: 0x06004A1F RID: 18975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A1F")]
		[Address(RVA = "0x1F147A4", Offset = "0x1F147A4", VA = "0x7BBC7147A4")]
		private void SetPreviwConfig(ref GameObject go, PreviewConfig.PreviewOneConifg configone, int subindex)
		{
		}

		// Token: 0x06004A20 RID: 18976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A20")]
		[Address(RVA = "0x1F15634", Offset = "0x1F15634", VA = "0x7BBC715634")]
		public void CGCameraChange()
		{
		}

		// Token: 0x06004A21 RID: 18977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A21")]
		[Address(RVA = "0x1F15858", Offset = "0x1F15858", VA = "0x7BBC715858")]
		public void CGCameraResume()
		{
		}

		// Token: 0x06004A22 RID: 18978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A22")]
		[Address(RVA = "0x1F15860", Offset = "0x1F15860", VA = "0x7BBC715860")]
		public void ForceSetCameraType(PreViewManager.Cameratype type)
		{
		}

		// Token: 0x06004A23 RID: 18979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A23")]
		[Address(RVA = "0x1F15868", Offset = "0x1F15868", VA = "0x7BBC715868")]
		public void ForceSetItemTouchArea()
		{
		}

		// Token: 0x06004A24 RID: 18980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A24")]
		[Address(RVA = "0x1F0DF3C", Offset = "0x1F0DF3C", VA = "0x7BBC70DF3C")]
		public void SwitchCamera(PreViewManager.Cameratype type)
		{
		}

		// Token: 0x06004A25 RID: 18981 RVA: 0x00016680 File Offset: 0x00014880
		[Token(Token = "0x6004A25")]
		[Address(RVA = "0x1F15A20", Offset = "0x1F15A20", VA = "0x7BBC715A20")]
		public PreViewManager.Cameratype CurrentCameraType()
		{
			return PreViewManager.Cameratype.None;
		}

		// Token: 0x06004A26 RID: 18982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A26")]
		[Address(RVA = "0x1F07888", Offset = "0x1F07888", VA = "0x7BBC707888")]
		public void CloseALLCamera()
		{
		}

		// Token: 0x06004A27 RID: 18983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A27")]
		[Address(RVA = "0x1F06E9C", Offset = "0x1F06E9C", VA = "0x7BBC706E9C")]
		private void CloseMixCamera()
		{
		}

		// Token: 0x06004A28 RID: 18984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A28")]
		[Address(RVA = "0x1F15A28", Offset = "0x1F15A28", VA = "0x7BBC715A28")]
		public void ReStoreMixcamera()
		{
		}

		// Token: 0x06004A29 RID: 18985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A29")]
		[Address(RVA = "0x1F15AD4", Offset = "0x1F15AD4", VA = "0x7BBC715AD4")]
		public void Clear3dModel()
		{
		}

		// Token: 0x06004A2A RID: 18986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A2A")]
		[Address(RVA = "0x1F15B80", Offset = "0x1F15B80", VA = "0x7BBC715B80")]
		public void SetPreviewAvatarLightVisble(bool flag)
		{
		}

		// Token: 0x06004A2B RID: 18987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A2B")]
		[Address(RVA = "0x1F15DC0", Offset = "0x1F15DC0", VA = "0x7BBC715DC0")]
		public void Clear2dItem()
		{
		}

		// Token: 0x06004A2C RID: 18988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A2C")]
		[Address(RVA = "0x1F15E5C", Offset = "0x1F15E5C", VA = "0x7BBC715E5C")]
		public void ShowPreview2DItem(bool show = true)
		{
		}

		// Token: 0x06004A2D RID: 18989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A2D")]
		[Address(RVA = "0x1F15F0C", Offset = "0x1F15F0C", VA = "0x7BBC715F0C")]
		public void ClearResourceRefCache()
		{
		}

		// Token: 0x06004A2E RID: 18990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A2E")]
		[Address(RVA = "0x1F00A90", Offset = "0x1F00A90", VA = "0x7BBC700A90")]
		public void ClearCache(bool clearall = false, bool clearPreviewAvatar = true)
		{
		}

		// Token: 0x06004A2F RID: 18991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A2F")]
		[Address(RVA = "0x1F1611C", Offset = "0x1F1611C", VA = "0x7BBC71611C")]
		private void ResetMixCameraRotation()
		{
		}

		// Token: 0x06004A30 RID: 18992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A30")]
		[Address(RVA = "0x1F07100", Offset = "0x1F07100", VA = "0x7BBC707100")]
		public void ClearZoomInfo()
		{
		}

		// Token: 0x06004A31 RID: 18993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A31")]
		[Address(RVA = "0x1F16230", Offset = "0x1F16230", VA = "0x7BBC716230")]
		public Camera GetMixCamera()
		{
			return null;
		}

		// Token: 0x06004A32 RID: 18994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A32")]
		[Address(RVA = "0x1F16238", Offset = "0x1F16238", VA = "0x7BBC716238")]
		public Camera GetItemCamera()
		{
			return null;
		}

		// Token: 0x06004A33 RID: 18995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A33")]
		[Address(RVA = "0x1F009F4", Offset = "0x1F009F4", VA = "0x7BBC7009F4")]
		public void DestoryCamera()
		{
		}

		// Token: 0x06004A34 RID: 18996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A34")]
		[Address(RVA = "0x1F09440", Offset = "0x1F09440", VA = "0x7BBC709440")]
		public void Show2dIcon(uint id)
		{
		}

		// Token: 0x06004A35 RID: 18997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A35")]
		[Address(RVA = "0x1F0D9D4", Offset = "0x1F0D9D4", VA = "0x7BBC70D9D4")]
		public void ShowSpecial2dIcon(AwardDesc awardItem, bool isShow = true, bool isBundle = false, bool refreshdesc = true)
		{
		}

		// Token: 0x06004A36 RID: 18998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A36")]
		[Address(RVA = "0x1F15F20", Offset = "0x1F15F20", VA = "0x7BBC715F20")]
		public void SetWeaponSkinUpgradeLevelVisble(bool isVisble)
		{
		}

		// Token: 0x06004A37 RID: 18999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A37")]
		[Address(RVA = "0x1F16240", Offset = "0x1F16240", VA = "0x7BBC716240")]
		public void SetBackPackVisble(bool isVisble)
		{
		}

		// Token: 0x06004A38 RID: 19000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A38")]
		[Address(RVA = "0x1F06228", Offset = "0x1F06228", VA = "0x7BBC706228")]
		public void SetHairStyleVisble(bool isVisble)
		{
		}

		// Token: 0x06004A39 RID: 19001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A39")]
		[Address(RVA = "0x1F05E34", Offset = "0x1F05E34", VA = "0x7BBC705E34")]
		public void SetMagnifierVisble(bool isVisble)
		{
		}

		// Token: 0x06004A3A RID: 19002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A3A")]
		[Address(RVA = "0x1F162F0", Offset = "0x1F162F0", VA = "0x7BBC7162F0")]
		public void CloseUIInGacha()
		{
		}

		// Token: 0x06004A3B RID: 19003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A3B")]
		[Address(RVA = "0x1F1638C", Offset = "0x1F1638C", VA = "0x7BBC71638C")]
		public void CloseAllPreviewUI(bool isclear = false)
		{
		}

		// Token: 0x06004A3C RID: 19004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A3C")]
		[Address(RVA = "0x1F1648C", Offset = "0x1F1648C", VA = "0x7BBC71648C")]
		public void RefreshCurrentId(uint itemid)
		{
		}

		// Token: 0x06004A3D RID: 19005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A3D")]
		[Address(RVA = "0x1F1653C", Offset = "0x1F1653C", VA = "0x7BBC71653C")]
		public void CloseUIExceptMagn()
		{
		}

		// Token: 0x06004A3E RID: 19006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A3E")]
		[Address(RVA = "0x1F165D8", Offset = "0x1F165D8", VA = "0x7BBC7165D8")]
		public void RefreshItemView(uint id)
		{
		}

		// Token: 0x06004A3F RID: 19007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A3F")]
		[Address(RVA = "0x1F166C8", Offset = "0x1F166C8", VA = "0x7BBC7166C8")]
		public void ClickDefaultBackPack()
		{
		}

		// Token: 0x06004A40 RID: 19008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A40")]
		[Address(RVA = "0x1F16764", Offset = "0x1F16764", VA = "0x7BBC716764")]
		public void ClickDefaultHairStyle()
		{
		}

		// Token: 0x06004A41 RID: 19009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A41")]
		[Address(RVA = "0x1F16800", Offset = "0x1F16800", VA = "0x7BBC716800")]
		private void AutoShift3DPreview(ref GameObject go, float scalex, float scaley, bool useY)
		{
		}

		// Token: 0x06004A42 RID: 19010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A42")]
		[Address(RVA = "0x1F17908", Offset = "0x1F17908", VA = "0x7BBC717908")]
		private void AutoGen3DPreviewCollider(GameObject go, bool isAvatar = false)
		{
		}

		// Token: 0x06004A43 RID: 19011 RVA: 0x00016698 File Offset: 0x00014898
		[Token(Token = "0x6004A43")]
		[Address(RVA = "0x1F17FC0", Offset = "0x1F17FC0", VA = "0x7BBC717FC0")]
		private bool CheckInvaildCollider(Renderer render)
		{
			return default(bool);
		}

		// Token: 0x06004A44 RID: 19012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A44")]
		[Address(RVA = "0x1F18160", Offset = "0x1F18160", VA = "0x7BBC718160")]
		public void CreateDoublePreviewAvatar(PlayDoubleAvatarAnimParams param)
		{
		}

		// Token: 0x06004A45 RID: 19013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A45")]
		[Address(RVA = "0x1F18AF0", Offset = "0x1F18AF0", VA = "0x7BBC718AF0")]
		public void PlayDoubleAvatarAnim()
		{
		}

		// Token: 0x06004A46 RID: 19014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A46")]
		[Address(RVA = "0x1F18C84", Offset = "0x1F18C84", VA = "0x7BBC718C84")]
		public void MarkDoubleSpecialAnim()
		{
		}

		// Token: 0x06004A47 RID: 19015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A47")]
		[Address(RVA = "0x1F18CA4", Offset = "0x1F18CA4", VA = "0x7BBC718CA4")]
		public void ClearMarkDoubleSpecialAnim()
		{
		}

		// Token: 0x06004A48 RID: 19016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A48")]
		[Address(RVA = "0x1F1889C", Offset = "0x1F1889C", VA = "0x7BBC71889C")]
		private UIMaleAvatar CreatePreview2PAvatar(List<uint> idlist, Vector3 scale, Vector3 pos, Vector3 quater, int doubleAnimid, string specialAnimid, string idleAnimid, bool uselight)
		{
			return null;
		}

		// Token: 0x06004A49 RID: 19017 RVA: 0x000166B0 File Offset: 0x000148B0
		[Token(Token = "0x6004A49")]
		[Address(RVA = "0x1F18CAC", Offset = "0x1F18CAC", VA = "0x7BBC718CAC")]
		private Vector3 GetBoxColliderCenterPosition(BoxCollider boxcollider)
		{
			return default(Vector3);
		}

		// Token: 0x06004A4A RID: 19018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A4A")]
		[Address(RVA = "0x1F18D94", Offset = "0x1F18D94", VA = "0x7BBC718D94")]
		public void CreateDoubleWeapon(uint weapon1, uint weapon2, PlayDoubleWeaponParams param1, PlayDoubleWeaponParams param2)
		{
		}

		// Token: 0x06004A4B RID: 19019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A4B")]
		[Address(RVA = "0x1F190D8", Offset = "0x1F190D8", VA = "0x7BBC7190D8")]
		private void CreatePreviewWeaponListItem(uint weaponid, PlayDoubleWeaponParams param)
		{
		}

		// Token: 0x06004A4C RID: 19020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A4C")]
		[Address(RVA = "0x1F1967C", Offset = "0x1F1967C", VA = "0x7BBC71967C")]
		public void CreateWeaponOrCg(uint weaponid, bool ShowUI)
		{
		}

		// Token: 0x06004A4D RID: 19021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A4D")]
		[Address(RVA = "0x1F19B44", Offset = "0x1F19B44", VA = "0x7BBC719B44")]
		public void DisableShowUI()
		{
		}

		// Token: 0x06004A4E RID: 19022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A4E")]
		[Address(RVA = "0x1F19684", Offset = "0x1F19684", VA = "0x7BBC719684")]
		public void CreatePreviewWeapon(uint weaponid, bool hasUI = true)
		{
		}

		// Token: 0x06004A4F RID: 19023 RVA: 0x000166C8 File Offset: 0x000148C8
		[Token(Token = "0x6004A4F")]
		[Address(RVA = "0x1F143AC", Offset = "0x1F143AC", VA = "0x7BBC7143AC")]
		public bool CheckIsGrenadeWeapon(uint weaponid)
		{
			return default(bool);
		}

		// Token: 0x06004A50 RID: 19024 RVA: 0x000166E0 File Offset: 0x000148E0
		[Token(Token = "0x6004A50")]
		[Address(RVA = "0x1F19B4C", Offset = "0x1F19B4C", VA = "0x7BBC719B4C")]
		public bool CheckIsDualWield(uint weaponid)
		{
			return default(bool);
		}

		// Token: 0x06004A51 RID: 19025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A51")]
		[Address(RVA = "0x1F0F198", Offset = "0x1F0F198", VA = "0x7BBC70F198")]
		private List<uint> GetCurrentClothesList()
		{
			return null;
		}

		// Token: 0x06004A52 RID: 19026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A52")]
		[Address(RVA = "0x1F19BE8", Offset = "0x1F19BE8", VA = "0x7BBC719BE8")]
		public UIMaleAvatar CreatePreviewEmoteAvatar()
		{
			return null;
		}

		// Token: 0x06004A53 RID: 19027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A53")]
		[Address(RVA = "0x1F19E14", Offset = "0x1F19E14", VA = "0x7BBC719E14")]
		public void PreviewEmote(UIMaleAvatar avatar, uint emoteid, bool isSelect, bool loop = false)
		{
		}

		// Token: 0x06004A54 RID: 19028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A54")]
		[Address(RVA = "0x1F19FC8", Offset = "0x1F19FC8", VA = "0x7BBC719FC8")]
		public void CreatePreviewAvatarWithBackpack(List<uint> idlist, uint collionid)
		{
		}

		// Token: 0x06004A55 RID: 19029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A55")]
		[Address(RVA = "0x1F13790", Offset = "0x1F13790", VA = "0x7BBC713790")]
		public void CreatePreviewAvatarWithWeapon(List<uint> idlist, uint weaponid)
		{
		}

		// Token: 0x06004A56 RID: 19030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A56")]
		[Address(RVA = "0x1F1AA30", Offset = "0x1F1AA30", VA = "0x7BBC71AA30")]
		public void UseMixCamera()
		{
		}

		// Token: 0x06004A57 RID: 19031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A57")]
		[Address(RVA = "0x1F1AA38", Offset = "0x1F1AA38", VA = "0x7BBC71AA38")]
		public void CreateSkyBoardToAvatar(uint id)
		{
		}

		// Token: 0x06004A58 RID: 19032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A58")]
		[Address(RVA = "0x1F0F5E8", Offset = "0x1F0F5E8", VA = "0x7BBC70F5E8")]
		public UIMaleAvatar CreateAvatar(List<uint> idlist, Vector3 scale, Vector3 pos, bool playSpecial, bool changanim = true, int doubleAnimid = 0, string resSpecial = "", string resIdle = "", bool uselight = true)
		{
			return null;
		}

		// Token: 0x06004A59 RID: 19033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A59")]
		[Address(RVA = "0x1F1ABE8", Offset = "0x1F1ABE8", VA = "0x7BBC71ABE8")]
		public void CreatePreviewAvatarWithCar(List<uint> idlist, uint carid)
		{
		}

		// Token: 0x06004A5A RID: 19034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A5A")]
		[Address(RVA = "0x1F1B298", Offset = "0x1F1B298", VA = "0x7BBC71B298")]
		public void ReplayCg()
		{
		}

		// Token: 0x06004A5B RID: 19035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A5B")]
		[Address(RVA = "0x1F1B558", Offset = "0x1F1B558", VA = "0x7BBC71B558")]
		public List<CSSharedItemData> TransformBundle2ItemList(CSSharedItemData item_data)
		{
			return null;
		}

		// Token: 0x06004A5C RID: 19036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A5C")]
		[Address(RVA = "0x1F1BA50", Offset = "0x1F1BA50", VA = "0x7BBC71BA50")]
		public List<uint> TransformBundleID2PreviewList(uint bundleid)
		{
			return null;
		}

		// Token: 0x06004A5D RID: 19037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A5D")]
		[Address(RVA = "0x1F1BE7C", Offset = "0x1F1BE7C", VA = "0x7BBC71BE7C")]
		private List<uint> TransformBundleList2PreviewList(List<BaseBundleItemInfo> bundle)
		{
			return null;
		}

		// Token: 0x06004A5E RID: 19038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A5E")]
		[Address(RVA = "0x1F0F8B0", Offset = "0x1F0F8B0", VA = "0x7BBC70F8B0")]
		private void AutoModifyPreviewModelAccordingToResolution(ref GameObject go, bool useY = false, float scaley = 0.5f, bool isAvatar = false)
		{
		}

		// Token: 0x06004A5F RID: 19039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A5F")]
		[Address(RVA = "0x1F0E1A4", Offset = "0x1F0E1A4", VA = "0x7BBC70E1A4")]
		private void AutoModifyPet(ref UIPetAvatar pet, bool useY = false, float scaley = 0.5f)
		{
		}

		// Token: 0x06004A60 RID: 19040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A60")]
		[Address(RVA = "0x1F1C2CC", Offset = "0x1F1C2CC", VA = "0x7BBC71C2CC")]
		public void PlayDoubleAnimIdle()
		{
		}

		// Token: 0x06004A61 RID: 19041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A61")]
		[Address(RVA = "0x1F1C3C0", Offset = "0x1F1C3C0", VA = "0x7BBC71C3C0")]
		public void PlayImdiateAnimIdle()
		{
		}

		// Token: 0x06004A62 RID: 19042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A62")]
		[Address(RVA = "0x1F1C4EC", Offset = "0x1F1C4EC", VA = "0x7BBC71C4EC")]
		public void SetDoubleAnimParm(bool flag)
		{
		}

		// Token: 0x06004A63 RID: 19043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A63")]
		[Address(RVA = "0x1F04108", Offset = "0x1F04108", VA = "0x7BBC704108")]
		public UIMaleAvatar GetCreateAvatar()
		{
			return null;
		}

		// Token: 0x06004A64 RID: 19044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A64")]
		[Address(RVA = "0x1F1C5F0", Offset = "0x1F1C5F0", VA = "0x7BBC71C5F0")]
		public UIMaleAvatar GetCachedAvatar()
		{
			return null;
		}

		// Token: 0x06004A65 RID: 19045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A65")]
		[Address(RVA = "0x1F1A924", Offset = "0x1F1A924", VA = "0x7BBC71A924")]
		public void UpdatePreviewAvatarBackPack(uint id)
		{
		}

		// Token: 0x06004A66 RID: 19046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A66")]
		[Address(RVA = "0x1F15908", Offset = "0x1F15908", VA = "0x7BBC715908")]
		private void CacheAvatarAnimtorSwitch(bool enabled)
		{
		}

		// Token: 0x06004A67 RID: 19047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A67")]
		[Address(RVA = "0x1F1C698", Offset = "0x1F1C698", VA = "0x7BBC71C698")]
		public void ForceAutoModifyDoubleAvatarPos()
		{
		}

		// Token: 0x06004A68 RID: 19048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A68")]
		[Address(RVA = "0x1F1C7C8", Offset = "0x1F1C7C8", VA = "0x7BBC71C7C8")]
		public void SetAutoModelPos(Vector3 x)
		{
		}

		// Token: 0x06004A69 RID: 19049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A69")]
		[Address(RVA = "0x1F1C894", Offset = "0x1F1C894", VA = "0x7BBC71C894")]
		public void CreatePreviewVfxCg(ResourceID cgid)
		{
		}

		// Token: 0x06004A6A RID: 19050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A6A")]
		[Address(RVA = "0x1F1CA20", Offset = "0x1F1CA20", VA = "0x7BBC71CA20")]
		public void CreatePreviewStoryCg(ResourceID cgid, uint uitype, bool isHas = false)
		{
		}

		// Token: 0x06004A6B RID: 19051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A6B")]
		[Address(RVA = "0x1F1CCAC", Offset = "0x1F1CCAC", VA = "0x7BBC71CCAC")]
		public void CreatePreviewSkinAnim(uint uitype, ResourceID resid)
		{
		}

		// Token: 0x06004A6C RID: 19052 RVA: 0x000166F8 File Offset: 0x000148F8
		[Token(Token = "0x6004A6C")]
		[Address(RVA = "0x1F1D050", Offset = "0x1F1D050", VA = "0x7BBC71D050")]
		public bool GetCurrentCgSkip()
		{
			return default(bool);
		}

		// Token: 0x06004A6D RID: 19053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A6D")]
		[Address(RVA = "0x1F1D16C", Offset = "0x1F1D16C", VA = "0x7BBC71D16C")]
		public void CreateLegendStoryCg()
		{
		}

		// Token: 0x06004A6E RID: 19054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A6E")]
		[Address(RVA = "0x1F1D658", Offset = "0x1F1D658", VA = "0x7BBC71D658")]
		public void SkipStoryCg()
		{
		}

		// Token: 0x06004A6F RID: 19055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A6F")]
		[Address(RVA = "0x1F1D850", Offset = "0x1F1D850", VA = "0x7BBC71D850")]
		public void AutoDestoryLegendCg()
		{
		}

		// Token: 0x06004A70 RID: 19056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A70")]
		[Address(RVA = "0x1F037E8", Offset = "0x1F037E8", VA = "0x7BBC7037E8")]
		public void ClosePreviewStoryCg()
		{
		}

		// Token: 0x06004A71 RID: 19057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A71")]
		[Address(RVA = "0x1F1DA10", Offset = "0x1F1DA10", VA = "0x7BBC71DA10")]
		public void CreateWeaponCg(uint weaponskinid, ResourceID weaponcgid, bool showUI = false)
		{
		}

		// Token: 0x06004A72 RID: 19058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A72")]
		[Address(RVA = "0x1F15FD0", Offset = "0x1F15FD0", VA = "0x7BBC715FD0")]
		public void CloseCG()
		{
		}

		// Token: 0x06004A73 RID: 19059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A73")]
		[Address(RVA = "0x1F1DC94", Offset = "0x1F1DC94", VA = "0x7BBC71DC94")]
		public void SetPreviewTweenEnabled(bool enabled)
		{
		}

		// Token: 0x06004A74 RID: 19060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A74")]
		[Address(RVA = "0x1F1DBE4", Offset = "0x1F1DBE4", VA = "0x7BBC71DBE4")]
		public void SetPreview3dItemEnabled(bool enabled)
		{
		}

		// Token: 0x06004A75 RID: 19061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A75")]
		[Address(RVA = "0x1F0A41C", Offset = "0x1F0A41C", VA = "0x7BBC70A41C")]
		public void CreatePreviewShowAnim(FullScreenAnimParams animParams, bool clearpool = true)
		{
		}

		// Token: 0x06004A76 RID: 19062 RVA: 0x00016710 File Offset: 0x00014910
		[Token(Token = "0x6004A76")]
		[Address(RVA = "0x1F1DEE0", Offset = "0x1F1DEE0", VA = "0x7BBC71DEE0")]
		public bool CheckCameraClick()
		{
			return default(bool);
		}

		// Token: 0x06004A77 RID: 19063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A77")]
		[Address(RVA = "0x1F1E008", Offset = "0x1F1E008", VA = "0x7BBC71E008")]
		public void ChangeCameraMove(bool isBoost)
		{
		}

		// Token: 0x06004A78 RID: 19064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A78")]
		[Address(RVA = "0x1F05EE4", Offset = "0x1F05EE4", VA = "0x7BBC705EE4")]
		public PreviewCameraMove GetAvatarCameraComp()
		{
			return null;
		}

		// Token: 0x06004A79 RID: 19065 RVA: 0x00016728 File Offset: 0x00014928
		[Token(Token = "0x6004A79")]
		[Address(RVA = "0x1F0C7E8", Offset = "0x1F0C7E8", VA = "0x7BBC70C7E8")]
		private uint SelectCustomAvatarID(bool isFemale)
		{
			return 0U;
		}

		// Token: 0x06004A7A RID: 19066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A7A")]
		[Address(RVA = "0x1F1E0F8", Offset = "0x1F1E0F8", VA = "0x7BBC71E0F8")]
		public void SetAvatarParams(Vector3 scale, Vector3 pos, PreViewManager.AvatarType type, Vector4 boostparams, bool Playpose = true, bool needStopEffect = true)
		{
		}

		// Token: 0x06004A7B RID: 19067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A7B")]
		[Address(RVA = "0x1F1E1F8", Offset = "0x1F1E1F8", VA = "0x7BBC71E1F8")]
		public void SetAvatarParams(bool needStopEffect)
		{
		}

		// Token: 0x06004A7C RID: 19068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A7C")]
		[Address(RVA = "0x1F1E20C", Offset = "0x1F1E20C", VA = "0x7BBC71E20C")]
		public void SetAvatarParamPlayPose(bool playPose)
		{
		}

		// Token: 0x06004A7D RID: 19069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A7D")]
		[Address(RVA = "0x1F1E220", Offset = "0x1F1E220", VA = "0x7BBC71E220")]
		public GameObject GetPreview3dItem()
		{
			return null;
		}

		// Token: 0x06004A7E RID: 19070 RVA: 0x00016740 File Offset: 0x00014940
		[Token(Token = "0x6004A7E")]
		[Address(RVA = "0x1F142F0", Offset = "0x1F142F0", VA = "0x7BBC7142F0")]
		public bool IsItemABReady(uint item_id)
		{
			return default(bool);
		}

		// Token: 0x06004A7F RID: 19071 RVA: 0x00016758 File Offset: 0x00014958
		[Token(Token = "0x6004A7F")]
		[Address(RVA = "0x1F1E228", Offset = "0x1F1E228", VA = "0x7BBC71E228")]
		public bool IsItemABReady(CSSharedItemData item_data)
		{
			return default(bool);
		}

		// Token: 0x06004A80 RID: 19072 RVA: 0x00016770 File Offset: 0x00014970
		[Token(Token = "0x6004A80")]
		[Address(RVA = "0x1F1E47C", Offset = "0x1F1E47C", VA = "0x7BBC71E47C")]
		public bool GetMagnifierState()
		{
			return default(bool);
		}

		// Token: 0x06004A81 RID: 19073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A81")]
		[Address(RVA = "0x1F1E51C", Offset = "0x1F1E51C", VA = "0x7BBC71E51C")]
		public void SkipSpecialAnim()
		{
		}

		// Token: 0x06004A82 RID: 19074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A82")]
		[Address(RVA = "0x1F1EA4C", Offset = "0x1F1EA4C", VA = "0x7BBC71EA4C")]
		public void SetIconSpPos()
		{
		}

		// Token: 0x06004A83 RID: 19075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A83")]
		[Address(RVA = "0x1F1EAE8", Offset = "0x1F1EAE8", VA = "0x7BBC71EAE8")]
		public void SetPreviewCgRotate(bool flag)
		{
		}

		// Token: 0x06004A84 RID: 19076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A84")]
		[Address(RVA = "0x1F1EBEC", Offset = "0x1F1EBEC", VA = "0x7BBC71EBEC")]
		public void FindItemNeedDownloadRes(CSSharedItemData item_data, ref List<ResourceID> need_download_res_list)
		{
		}

		// Token: 0x06004A85 RID: 19077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A85")]
		[Address(RVA = "0x1F1EDF0", Offset = "0x1F1EDF0", VA = "0x7BBC71EDF0")]
		public void SetCollecionBg(bool flag)
		{
		}

		// Token: 0x06004A86 RID: 19078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A86")]
		[Address(RVA = "0x1F1EEA0", Offset = "0x1F1EEA0", VA = "0x7BBC71EEA0")]
		public void EnableOptionalDownloadRefresh(bool enable)
		{
		}

		// Token: 0x06004A87 RID: 19079 RVA: 0x00016788 File Offset: 0x00014988
		[Token(Token = "0x6004A87")]
		[Address(RVA = "0x1F1EF3C", Offset = "0x1F1EF3C", VA = "0x7BBC71EF3C")]
		public int RefreshPreviewPanelDepth(int baseDepth, bool includeSelf = true)
		{
			return 0;
		}

		// Token: 0x06004A88 RID: 19080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A88")]
		[Address(RVA = "0x1F1F120", Offset = "0x1F1F120", VA = "0x7BBC71F120")]
		public PreViewManager()
		{
		}

		// Token: 0x04007294 RID: 29332
		[Token(Token = "0x4007294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private uint m_CustomAvatarIdF;

		// Token: 0x04007295 RID: 29333
		[Token(Token = "0x4007295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private uint m_CustomAvatarIdM;

		// Token: 0x04007296 RID: 29334
		[Token(Token = "0x4007296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private uint m_DefaultBundleMale;

		// Token: 0x04007297 RID: 29335
		[Token(Token = "0x4007297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private uint m_DefaultBundleFemale;

		// Token: 0x04007298 RID: 29336
		[Token(Token = "0x4007298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private ECollectionLevel m_CurrentCollectionLevel;

		// Token: 0x04007299 RID: 29337
		[Token(Token = "0x4007299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GameObject m_ItemCameraGo;

		// Token: 0x0400729A RID: 29338
		[Token(Token = "0x400729A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Camera m_ItemCamera;

		// Token: 0x0400729B RID: 29339
		[Token(Token = "0x400729B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GameObject m_MixCameraGo;

		// Token: 0x0400729C RID: 29340
		[Token(Token = "0x400729C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Camera m_MixCamera;

		// Token: 0x0400729D RID: 29341
		[Token(Token = "0x400729D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private GameObject m_TouchArea;

		// Token: 0x0400729E RID: 29342
		[Token(Token = "0x400729E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GameObject m_Preview3DItem;

		// Token: 0x0400729F RID: 29343
		[Token(Token = "0x400729F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private UIMaleAvatar m_PreviewAvatar;

		// Token: 0x040072A0 RID: 29344
		[Token(Token = "0x40072A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private UIMaleAvatar m_PreviewAvatar2P;

		// Token: 0x040072A1 RID: 29345
		[Token(Token = "0x40072A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private UIMaleAvatar m_PreviewCachedAvatar;

		// Token: 0x040072A2 RID: 29346
		[Token(Token = "0x40072A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private UIPetAvatar m_PetAvatar;

		// Token: 0x040072A3 RID: 29347
		[Token(Token = "0x40072A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private EFrontendUIType m_UItype;

		// Token: 0x040072A4 RID: 29348
		[Token(Token = "0x40072A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private PreViewManager.Cameratype MyCameratype;

		// Token: 0x040072A5 RID: 29349
		[Token(Token = "0x40072A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool hasenter;

		// Token: 0x040072A6 RID: 29350
		[Token(Token = "0x40072A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		private bool isSpecialPack;

		// Token: 0x040072A7 RID: 29351
		[Token(Token = "0x40072A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private UIModelStoreBox m_modelStoreBox;

		// Token: 0x040072A8 RID: 29352
		[Token(Token = "0x40072A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private UIModelAvatar m_ModelAvatar;

		// Token: 0x040072A9 RID: 29353
		[Token(Token = "0x40072A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112F6CC", Offset = "0x112F6CC")]
		private bool <IgnoreManualChange>k__BackingField;

		// Token: 0x040072AA RID: 29354
		[Token(Token = "0x40072AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private UIPreviewItemController m_PreviewPanel;

		// Token: 0x040072AB RID: 29355
		[Token(Token = "0x40072AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static PreviewConfig m_Preconfig;

		// Token: 0x040072AC RID: 29356
		[Token(Token = "0x40072AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float m_LocalMallAvatarx;

		// Token: 0x040072AD RID: 29357
		[Token(Token = "0x40072AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private GameObject m_PreviewCG;

		// Token: 0x040072AE RID: 29358
		[Token(Token = "0x40072AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private GameObject m_LegendPreviewCg;

		// Token: 0x040072AF RID: 29359
		[Token(Token = "0x40072AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private GameObject m_GroundShadow;

		// Token: 0x040072B0 RID: 29360
		[Token(Token = "0x40072B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private UIWeaponZoomInController m_ZoomInController;

		// Token: 0x040072B1 RID: 29361
		[Token(Token = "0x40072B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private uint m_MarkDoubleAnimCount;

		// Token: 0x040072B2 RID: 29362
		[Token(Token = "0x40072B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private List<GameObject> m_WeaponPreviewShowList;

		// Token: 0x040072B3 RID: 29363
		[Token(Token = "0x40072B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private PreviewAvatarParams m_PreviewAvatarParams;

		// Token: 0x040072B4 RID: 29364
		[Token(Token = "0x40072B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private bool m_isShowUI;

		// Token: 0x040072B5 RID: 29365
		[Token(Token = "0x40072B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private List<Vector3> m_PreviewCgScaleList;

		// Token: 0x040072B6 RID: 29366
		[Token(Token = "0x40072B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Camera bg_camera;

		// Token: 0x040072B7 RID: 29367
		[Token(Token = "0x40072B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private ResourceRefCache m_3dModelRefCache;

		// Token: 0x040072B8 RID: 29368
		[Token(Token = "0x40072B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public uint m_ShowWeaponid;

		// Token: 0x040072B9 RID: 29369
		[Token(Token = "0x40072B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private readonly Dictionary<EFrontendUIType, PreViewManager.PreviewInfo_2DItem> _Preview2D;

		// Token: 0x02001297 RID: 4759
		[Token(Token = "0x2001297")]
		public enum Cameratype
		{
			// Token: 0x040072BB RID: 29371
			[Token(Token = "0x40072BB")]
			None,
			// Token: 0x040072BC RID: 29372
			[Token(Token = "0x40072BC")]
			AvatarCamera,
			// Token: 0x040072BD RID: 29373
			[Token(Token = "0x40072BD")]
			ItemCamera,
			// Token: 0x040072BE RID: 29374
			[Token(Token = "0x40072BE")]
			MixCamera
		}

		// Token: 0x02001298 RID: 4760
		[Token(Token = "0x2001298")]
		public enum AnimType
		{
			// Token: 0x040072C0 RID: 29376
			[Token(Token = "0x40072C0")]
			SpecialAnim = 1,
			// Token: 0x040072C1 RID: 29377
			[Token(Token = "0x40072C1")]
			FullCG,
			// Token: 0x040072C2 RID: 29378
			[Token(Token = "0x40072C2")]
			SkinShowAnim
		}

		// Token: 0x02001299 RID: 4761
		[Token(Token = "0x2001299")]
		public enum AvatarType
		{
			// Token: 0x040072C4 RID: 29380
			[Token(Token = "0x40072C4")]
			localAvatar,
			// Token: 0x040072C5 RID: 29381
			[Token(Token = "0x40072C5")]
			AvatarWithNoCache,
			// Token: 0x040072C6 RID: 29382
			[Token(Token = "0x40072C6")]
			AvatarWithCache,
			// Token: 0x040072C7 RID: 29383
			[Token(Token = "0x40072C7")]
			AvatarWithNoPool
		}

		// Token: 0x0200129A RID: 4762
		[Token(Token = "0x200129A")]
		public enum CollectionPreviewType
		{
			// Token: 0x040072C9 RID: 29385
			[Token(Token = "0x40072C9")]
			BackPack,
			// Token: 0x040072CA RID: 29386
			[Token(Token = "0x40072CA")]
			BootyBox,
			// Token: 0x040072CB RID: 29387
			[Token(Token = "0x40072CB")]
			ParaChute,
			// Token: 0x040072CC RID: 29388
			[Token(Token = "0x40072CC")]
			SkyBoard,
			// Token: 0x040072CD RID: 29389
			[Token(Token = "0x40072CD")]
			WeaponSkin,
			// Token: 0x040072CE RID: 29390
			[Token(Token = "0x40072CE")]
			VehicleSkin,
			// Token: 0x040072CF RID: 29391
			[Token(Token = "0x40072CF")]
			WeaponMeleeSkin,
			// Token: 0x040072D0 RID: 29392
			[Token(Token = "0x40072D0")]
			WeaponGrenadeSkin,
			// Token: 0x040072D1 RID: 29393
			[Token(Token = "0x40072D1")]
			Emote,
			// Token: 0x040072D2 RID: 29394
			[Token(Token = "0x40072D2")]
			RedEnvelope,
			// Token: 0x040072D3 RID: 29395
			[Token(Token = "0x40072D3")]
			PetCat,
			// Token: 0x040072D4 RID: 29396
			[Token(Token = "0x40072D4")]
			Flight
		}

		// Token: 0x0200129B RID: 4763
		[Token(Token = "0x200129B")]
		public enum PetPreviewType
		{
			// Token: 0x040072D6 RID: 29398
			[Token(Token = "0x40072D6")]
			PetModel,
			// Token: 0x040072D7 RID: 29399
			[Token(Token = "0x40072D7")]
			PetSkin = 10,
			// Token: 0x040072D8 RID: 29400
			[Token(Token = "0x40072D8")]
			PetRation = 7,
			// Token: 0x040072D9 RID: 29401
			[Token(Token = "0x40072D9")]
			PetAnima = 9
		}

		// Token: 0x0200129C RID: 4764
		[Token(Token = "0x200129C")]
		private class PreviewInfo_2DItem
		{
			// Token: 0x06004A89 RID: 19081 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004A89")]
			[Address(RVA = "0x1743488", Offset = "0x1743488", VA = "0x7BBBF43488")]
			public PreviewInfo_2DItem()
			{
			}

			// Token: 0x040072DA RID: 29402
			[Token(Token = "0x40072DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool IsLeft;

			// Token: 0x040072DB RID: 29403
			[Token(Token = "0x40072DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int Left;

			// Token: 0x040072DC RID: 29404
			[Token(Token = "0x40072DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int Right;

			// Token: 0x040072DD RID: 29405
			[Token(Token = "0x40072DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int Top;

			// Token: 0x040072DE RID: 29406
			[Token(Token = "0x40072DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int Bottom;
		}
	}
}
