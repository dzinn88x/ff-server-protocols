using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using proto;
using tcp;
using UnityEngine;

namespace COW
{
	// Token: 0x020016D5 RID: 5845
	[Token(Token = "0x20016D5")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F0E3C", Offset = "0x10F0E3C")]
	internal class UIAvatarWindowController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x06006B8B RID: 27531 RVA: 0x0001E720 File Offset: 0x0001C920
		[Token(Token = "0x6006B8B")]
		[Address(RVA = "0x1E55BF4", Offset = "0x1E55BF4", VA = "0x7BBC655BF4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06006B8D RID: 27533 RVA: 0x0001E738 File Offset: 0x0001C938
		// (set) Token: 0x06006B8C RID: 27532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000926")]
		public ulong TargetShowPopMenuAccountID
		{
			[Token(Token = "0x6006B8D")]
			[Address(RVA = "0x1E55C4C", Offset = "0x1E55C4C", VA = "0x7BBC655C4C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11411C8", Offset = "0x11411C8")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6006B8C")]
			[Address(RVA = "0x1E55C44", Offset = "0x1E55C44", VA = "0x7BBC655C44")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11411B8", Offset = "0x11411B8")]
			set
			{
			}
		}

		// Token: 0x06006B8E RID: 27534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B8E")]
		[Address(RVA = "0x1E55C54", Offset = "0x1E55C54", VA = "0x7BBC655C54", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006B8F RID: 27535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B8F")]
		[Address(RVA = "0x1E59D70", Offset = "0x1E59D70", VA = "0x7BBC659D70", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006B90 RID: 27536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B90")]
		[Address(RVA = "0x1E5875C", Offset = "0x1E5875C", VA = "0x7BBC65875C")]
		private void CreatePetAvatar(params object[] data)
		{
		}

		// Token: 0x06006B91 RID: 27537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B91")]
		[Address(RVA = "0x1E5C368", Offset = "0x1E5C368", VA = "0x7BBC65C368")]
		public void CreateAvatarLight(EFrontendUIType uitype)
		{
		}

		// Token: 0x06006B92 RID: 27538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B92")]
		[Address(RVA = "0x1E5C510", Offset = "0x1E5C510", VA = "0x7BBC65C510")]
		private void OnShowPetActionGuide(params object[] param)
		{
		}

		// Token: 0x06006B93 RID: 27539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B93")]
		[Address(RVA = "0x1E5C9BC", Offset = "0x1E5C9BC", VA = "0x7BBC65C9BC")]
		private void OnHidePetActionGuide(params object[] param)
		{
		}

		// Token: 0x06006B94 RID: 27540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B94")]
		[Address(RVA = "0x1E5CC44", Offset = "0x1E5CC44", VA = "0x7BBC65CC44")]
		private void OnShowAvatarGuideEffect(params object[] param)
		{
		}

		// Token: 0x06006B95 RID: 27541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B95")]
		[Address(RVA = "0x1E5CC48", Offset = "0x1E5CC48", VA = "0x7BBC65CC48")]
		private void OnHideAvatarGuideEffect(params object[] param)
		{
		}

		// Token: 0x06006B96 RID: 27542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B96")]
		[Address(RVA = "0x1E5CAC4", Offset = "0x1E5CAC4", VA = "0x7BBC65CAC4")]
		private void OnClickPet()
		{
		}

		// Token: 0x06006B97 RID: 27543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B97")]
		[Address(RVA = "0x1E5BE0C", Offset = "0x1E5BE0C", VA = "0x7BBC65BE0C")]
		private void OnDestoryAvatarParticle(params object[] data)
		{
		}

		// Token: 0x06006B98 RID: 27544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B98")]
		[Address(RVA = "0x1E5CE74", Offset = "0x1E5CE74", VA = "0x7BBC65CE74")]
		private void OnCreateAvatarParticle(params object[] data)
		{
		}

		// Token: 0x06006B99 RID: 27545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B99")]
		[Address(RVA = "0x1E5D1EC", Offset = "0x1E5D1EC", VA = "0x7BBC65D1EC")]
		private void OnAvatarInitReady(bool isLocal)
		{
		}

		// Token: 0x06006B9A RID: 27546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B9A")]
		[Address(RVA = "0x1E5D668", Offset = "0x1E5D668", VA = "0x7BBC65D668")]
		private void OnWardrobeEnter(params object[] data)
		{
		}

		// Token: 0x06006B9B RID: 27547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B9B")]
		[Address(RVA = "0x1E5D670", Offset = "0x1E5D670", VA = "0x7BBC65D670")]
		private void OnPetWindowEnter(params object[] data)
		{
		}

		// Token: 0x06006B9C RID: 27548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B9C")]
		[Address(RVA = "0x1E5D678", Offset = "0x1E5D678", VA = "0x7BBC65D678")]
		private void OnProfileEnter(object[] data)
		{
		}

		// Token: 0x06006B9D RID: 27549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B9D")]
		[Address(RVA = "0x1E5DB08", Offset = "0x1E5DB08", VA = "0x7BBC65DB08")]
		private void OnProfileExit(object[] data)
		{
		}

		// Token: 0x06006B9E RID: 27550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B9E")]
		[Address(RVA = "0x1E5DB38", Offset = "0x1E5DB38", VA = "0x7BBC65DB38")]
		private void OnPVEPrepareEnter(object[] data)
		{
		}

		// Token: 0x06006B9F RID: 27551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B9F")]
		[Address(RVA = "0x1E5DB64", Offset = "0x1E5DB64", VA = "0x7BBC65DB64")]
		private void ChangeAvatarCamera(object[] data)
		{
		}

		// Token: 0x06006BA0 RID: 27552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BA0")]
		[Address(RVA = "0x1E58FA4", Offset = "0x1E58FA4", VA = "0x7BBC658FA4")]
		private void OnAvatarCameraStateChange(params object[] data)
		{
		}

		// Token: 0x06006BA1 RID: 27553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BA1")]
		[Address(RVA = "0x1E5DC2C", Offset = "0x1E5DC2C", VA = "0x7BBC65DC2C")]
		private void OnAvatarInputEnableState(params object[] data)
		{
		}

		// Token: 0x06006BA2 RID: 27554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BA2")]
		[Address(RVA = "0x1E5DD24", Offset = "0x1E5DD24", VA = "0x7BBC65DD24")]
		private void OnAvatarStateChange(params object[] data)
		{
		}

		// Token: 0x06006BA3 RID: 27555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BA3")]
		[Address(RVA = "0x1E59298", Offset = "0x1E59298", VA = "0x7BBC659298")]
		private void OnLobbyGroupEnter(params object[] data)
		{
		}

		// Token: 0x06006BA4 RID: 27556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BA4")]
		[Address(RVA = "0x1E5FCA0", Offset = "0x1E5FCA0", VA = "0x7BBC65FCA0")]
		private void OnGroupInfoClear(object[] data)
		{
		}

		// Token: 0x06006BA5 RID: 27557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BA5")]
		[Address(RVA = "0x1E58EB4", Offset = "0x1E58EB4", VA = "0x7BBC658EB4")]
		private void OnLobbyEnter(params object[] data)
		{
		}

		// Token: 0x06006BA6 RID: 27558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BA6")]
		[Address(RVA = "0x1E5FD20", Offset = "0x1E5FD20", VA = "0x7BBC65FD20")]
		private void OnEnterPortraitCloseup(object[] data)
		{
		}

		// Token: 0x06006BA7 RID: 27559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BA7")]
		[Address(RVA = "0x1E5FD48", Offset = "0x1E5FD48", VA = "0x7BBC65FD48")]
		private void OnEnterAvatarProfile(object[] data)
		{
		}

		// Token: 0x06006BA8 RID: 27560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BA8")]
		[Address(RVA = "0x1E5FD50", Offset = "0x1E5FD50", VA = "0x7BBC65FD50")]
		private void OnEnterWeaponSkinUpgrader(object[] data)
		{
		}

		// Token: 0x06006BA9 RID: 27561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BA9")]
		[Address(RVA = "0x1E5FD58", Offset = "0x1E5FD58", VA = "0x7BBC65FD58")]
		private void OnEnterLegendClothVault(object[] data)
		{
		}

		// Token: 0x06006BAA RID: 27562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BAA")]
		[Address(RVA = "0x1E5FD84", Offset = "0x1E5FD84", VA = "0x7BBC65FD84")]
		private void OnExitLegendClothVault(object[] data)
		{
		}

		// Token: 0x06006BAB RID: 27563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BAB")]
		[Address(RVA = "0x1E5FD88", Offset = "0x1E5FD88", VA = "0x7BBC65FD88")]
		private void OnMallEnter(params object[] data)
		{
		}

		// Token: 0x06006BAC RID: 27564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BAC")]
		[Address(RVA = "0x1E5FE18", Offset = "0x1E5FE18", VA = "0x7BBC65FE18")]
		private void OnForgeEnter(params object[] data)
		{
		}

		// Token: 0x06006BAD RID: 27565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BAD")]
		[Address(RVA = "0x1E5FEA4", Offset = "0x1E5FEA4", VA = "0x7BBC65FEA4")]
		private void OnGachaEnter(params object[] data)
		{
		}

		// Token: 0x06006BAE RID: 27566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BAE")]
		[Address(RVA = "0x1E5FF40", Offset = "0x1E5FF40", VA = "0x7BBC65FF40")]
		private void OnCollectionEnter(params object[] data)
		{
		}

		// Token: 0x06006BAF RID: 27567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BAF")]
		[Address(RVA = "0x1E5FFCC", Offset = "0x1E5FFCC", VA = "0x7BBC65FFCC")]
		private void OnIAPBundleEnter(params object[] data)
		{
		}

		// Token: 0x06006BB0 RID: 27568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BB0")]
		[Address(RVA = "0x1E600C8", Offset = "0x1E600C8", VA = "0x7BBC6600C8")]
		private void OnProfileShareEnter(params object[] data)
		{
		}

		// Token: 0x06006BB1 RID: 27569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BB1")]
		[Address(RVA = "0x1E60794", Offset = "0x1E60794", VA = "0x7BBC660794")]
		private void OnLadderEnter(params object[] data)
		{
		}

		// Token: 0x06006BB2 RID: 27570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BB2")]
		[Address(RVA = "0x1E6079C", Offset = "0x1E6079C", VA = "0x7BBC66079C")]
		private void OnGainItemEnter(params object[] data)
		{
		}

		// Token: 0x06006BB3 RID: 27571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BB3")]
		[Address(RVA = "0x1E607A4", Offset = "0x1E607A4", VA = "0x7BBC6607A4")]
		private void OnElitePassEnter(params object[] data)
		{
		}

		// Token: 0x06006BB4 RID: 27572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BB4")]
		[Address(RVA = "0x1E5D734", Offset = "0x1E5D734", VA = "0x7BBC65D734")]
		private void AutoModifyCamera()
		{
		}

		// Token: 0x06006BB5 RID: 27573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BB5")]
		[Address(RVA = "0x1E607CC", Offset = "0x1E607CC", VA = "0x7BBC6607CC")]
		private void OnGroupQuitClearAvatar(params object[] data)
		{
		}

		// Token: 0x06006BB6 RID: 27574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BB6")]
		[Address(RVA = "0x1E60B00", Offset = "0x1E60B00", VA = "0x7BBC660B00")]
		private void OnGroupCreate(params object[] data)
		{
		}

		// Token: 0x06006BB7 RID: 27575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BB7")]
		[Address(RVA = "0x1E595D0", Offset = "0x1E595D0", VA = "0x7BBC6595D0")]
		private void OnGroupJoin(params object[] data)
		{
		}

		// Token: 0x06006BB8 RID: 27576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BB8")]
		[Address(RVA = "0x1E60B30", Offset = "0x1E60B30", VA = "0x7BBC660B30")]
		private void OnGroupMemberShowEmote(params object[] data)
		{
		}

		// Token: 0x06006BB9 RID: 27577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BB9")]
		[Address(RVA = "0x1E60E5C", Offset = "0x1E60E5C", VA = "0x7BBC660E5C")]
		private void OnGroupPetShowAction(params object[] data)
		{
		}

		// Token: 0x06006BBA RID: 27578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BBA")]
		[Address(RVA = "0x1E6114C", Offset = "0x1E6114C", VA = "0x7BBC66114C")]
		private void UpdateAvatarPetShow()
		{
		}

		// Token: 0x06006BBB RID: 27579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BBB")]
		[Address(RVA = "0x1E6199C", Offset = "0x1E6199C", VA = "0x7BBC66199C")]
		private void UpdateGroupAvatarsClothes()
		{
		}

		// Token: 0x06006BBC RID: 27580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BBC")]
		[Address(RVA = "0x1E5DEFC", Offset = "0x1E5DEFC", VA = "0x7BBC65DEFC")]
		private void ShowAvatars()
		{
		}

		// Token: 0x06006BBD RID: 27581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BBD")]
		[Address(RVA = "0x1E621A0", Offset = "0x1E621A0", VA = "0x7BBC6621A0")]
		private void OnGroupLeaveNtf(params object[] data)
		{
		}

		// Token: 0x06006BBE RID: 27582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BBE")]
		[Address(RVA = "0x1E5D830", Offset = "0x1E5D830", VA = "0x7BBC65D830")]
		private void PlayAvatarShowPose(bool takeWeapon = false, bool force = false)
		{
		}

		// Token: 0x06006BBF RID: 27583 RVA: 0x0001E750 File Offset: 0x0001C950
		[Token(Token = "0x6006BBF")]
		[Address(RVA = "0x1E61F30", Offset = "0x1E61F30", VA = "0x7BBC661F30")]
		private bool ShowPVEWeapon()
		{
			return default(bool);
		}

		// Token: 0x06006BC0 RID: 27584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BC0")]
		[Address(RVA = "0x1E627E4", Offset = "0x1E627E4", VA = "0x7BBC6627E4")]
		private void OnRefreshWeapon(params object[] data)
		{
		}

		// Token: 0x06006BC1 RID: 27585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BC1")]
		[Address(RVA = "0x1E62AAC", Offset = "0x1E62AAC", VA = "0x7BBC662AAC")]
		private void OnRefreshWeaponOnHand(params object[] data)
		{
		}

		// Token: 0x06006BC2 RID: 27586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BC2")]
		[Address(RVA = "0x1E62B34", Offset = "0x1E62B34", VA = "0x7BBC662B34")]
		private void RefreshSelfWeaponOnHand()
		{
		}

		// Token: 0x06006BC3 RID: 27587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BC3")]
		[Address(RVA = "0x1E62B68", Offset = "0x1E62B68", VA = "0x7BBC662B68")]
		private void RefreshTeamateWeaponOnHand(params object[] data)
		{
		}

		// Token: 0x06006BC4 RID: 27588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BC4")]
		[Address(RVA = "0x1E62D34", Offset = "0x1E62D34", VA = "0x7BBC662D34")]
		private void RefreshTeamatePVEWeapon()
		{
		}

		// Token: 0x06006BC5 RID: 27589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BC5")]
		[Address(RVA = "0x1E62730", Offset = "0x1E62730", VA = "0x7BBC662730")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x11411D8", Offset = "0x11411D8")]
		private IEnumerator PlayAvatarShowPose(UIMaleAvatar avatar, float seconds)
		{
			return null;
		}

		// Token: 0x06006BC6 RID: 27590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BC6")]
		[Address(RVA = "0x1E62688", Offset = "0x1E62688", VA = "0x7BBC662688")]
		private void OnStopAvatarShowPose(params object[] data)
		{
		}

		// Token: 0x06006BC7 RID: 27591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BC7")]
		[Address(RVA = "0x1E62FB4", Offset = "0x1E62FB4", VA = "0x7BBC662FB4")]
		private void OnInviteBtnClick(int member_idx, ulong friendid)
		{
		}

		// Token: 0x06006BC8 RID: 27592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BC8")]
		[Address(RVA = "0x1E63094", Offset = "0x1E63094", VA = "0x7BBC663094")]
		private void OnGroupQuit(object[] data)
		{
		}

		// Token: 0x06006BC9 RID: 27593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BC9")]
		[Address(RVA = "0x1E63198", Offset = "0x1E63198", VA = "0x7BBC663198")]
		private void OnGroupDismissNtf(params object[] data)
		{
		}

		// Token: 0x06006BCA RID: 27594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BCA")]
		[Address(RVA = "0x1E6328C", Offset = "0x1E6328C", VA = "0x7BBC66328C")]
		private void OnGroupReadyNtf(params object[] data)
		{
		}

		// Token: 0x06006BCB RID: 27595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BCB")]
		[Address(RVA = "0x1E636A4", Offset = "0x1E636A4", VA = "0x7BBC6636A4")]
		private void onGroupStopNtf(params object[] data)
		{
		}

		// Token: 0x06006BCC RID: 27596 RVA: 0x0001E768 File Offset: 0x0001C968
		[Token(Token = "0x6006BCC")]
		[Address(RVA = "0x1E5C894", Offset = "0x1E5C894", VA = "0x7BBC65C894")]
		private Vector3 ScreenToLocalPosition(Vector3 pos)
		{
			return default(Vector3);
		}

		// Token: 0x06006BCD RID: 27597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BCD")]
		[Address(RVA = "0x1E63AA8", Offset = "0x1E63AA8", VA = "0x7BBC663AA8")]
		private void Update()
		{
		}

		// Token: 0x06006BCE RID: 27598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BCE")]
		[Address(RVA = "0x1E57BE4", Offset = "0x1E57BE4", VA = "0x7BBC657BE4")]
		private void SetAvatarRelatedPos(EFrontendUIType uiType)
		{
		}

		// Token: 0x06006BCF RID: 27599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BCF")]
		[Address(RVA = "0x1E5BF90", Offset = "0x1E5BF90", VA = "0x7BBC65BF90")]
		private void SetAvatarPet()
		{
		}

		// Token: 0x06006BD0 RID: 27600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BD0")]
		[Address(RVA = "0x1E63F2C", Offset = "0x1E63F2C", VA = "0x7BBC663F2C")]
		private void ShowPetLobbyAction(params object[] param)
		{
		}

		// Token: 0x06006BD1 RID: 27601 RVA: 0x0001E780 File Offset: 0x0001C980
		[Token(Token = "0x6006BD1")]
		[Address(RVA = "0x1E62A7C", Offset = "0x1E62A7C", VA = "0x7BBC662A7C")]
		private bool ShowWeaponInCurrentUI()
		{
			return default(bool);
		}

		// Token: 0x06006BD2 RID: 27602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BD2")]
		[Address(RVA = "0x1E63CDC", Offset = "0x1E63CDC", VA = "0x7BBC663CDC")]
		private void ShowTeamAvatars(bool isVisible)
		{
		}

		// Token: 0x06006BD3 RID: 27603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BD3")]
		[Address(RVA = "0x1E641D0", Offset = "0x1E641D0", VA = "0x7BBC6641D0")]
		private void OnResetGachaAvatar(params object[] data)
		{
		}

		// Token: 0x06006BD4 RID: 27604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BD4")]
		[Address(RVA = "0x1E61F38", Offset = "0x1E61F38", VA = "0x7BBC661F38")]
		private void ShowWeaponAnim(uint skinId, UIMaleAvatar avatar, bool force = false)
		{
		}

		// Token: 0x06006BD5 RID: 27605 RVA: 0x0001E798 File Offset: 0x0001C998
		[Token(Token = "0x6006BD5")]
		[Address(RVA = "0x1E62A90", Offset = "0x1E62A90", VA = "0x7BBC662A90")]
		public bool CheckIsDualWield(WeaponSkinData data)
		{
			return default(bool);
		}

		// Token: 0x06006BD6 RID: 27606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BD6")]
		[Address(RVA = "0x1E642F0", Offset = "0x1E642F0", VA = "0x7BBC6642F0", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06006BD7 RID: 27607 RVA: 0x0001E7B0 File Offset: 0x0001C9B0
		[Token(Token = "0x6006BD7")]
		[Address(RVA = "0x1E64850", Offset = "0x1E64850", VA = "0x7BBC664850", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06006BD8 RID: 27608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BD8")]
		[Address(RVA = "0x1E5BCF4", Offset = "0x1E5BCF4", VA = "0x7BBC65BCF4")]
		private void DestroyAvatar(UIMaleAvatar a)
		{
		}

		// Token: 0x06006BD9 RID: 27609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BD9")]
		[Address(RVA = "0x1E64904", Offset = "0x1E64904", VA = "0x7BBC664904")]
		private void OnPlayerUpdateShadowPos(params object[] data)
		{
		}

		// Token: 0x06006BDA RID: 27610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BDA")]
		[Address(RVA = "0x1E60464", Offset = "0x1E60464", VA = "0x7BBC660464")]
		private void UpdateLocalPlayerShadowPos()
		{
		}

		// Token: 0x06006BDB RID: 27611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BDB")]
		[Address(RVA = "0x1E5FA84", Offset = "0x1E5FA84", VA = "0x7BBC65FA84")]
		private void ShowLocalPlayerShadow(bool show)
		{
		}

		// Token: 0x06006BDC RID: 27612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BDC")]
		[Address(RVA = "0x1E64908", Offset = "0x1E64908", VA = "0x7BBC664908")]
		public UIAvatarWindowController()
		{
		}

		// Token: 0x04008764 RID: 34660
		[Token(Token = "0x4008764")]
		[FieldOffset(Offset = "0x58")]
		private UIAvatarWindowView m_View;

		// Token: 0x04008765 RID: 34661
		[Token(Token = "0x4008765")]
		[FieldOffset(Offset = "0x60")]
		private UIMaleAvatar m_Avatar;

		// Token: 0x04008766 RID: 34662
		[Token(Token = "0x4008766")]
		[FieldOffset(Offset = "0x68")]
		private UIPetAvatar m_PetAvatar;

		// Token: 0x04008767 RID: 34663
		[Token(Token = "0x4008767")]
		[FieldOffset(Offset = "0x70")]
		private proto.PetInfo m_CurrentShowPetInfo;

		// Token: 0x04008768 RID: 34664
		[Token(Token = "0x4008768")]
		[FieldOffset(Offset = "0x78")]
		private float m_PetLobbyScale;

		// Token: 0x04008769 RID: 34665
		[Token(Token = "0x4008769")]
		[FieldOffset(Offset = "0x80")]
		private GameObject m_AvatarCamera;

		// Token: 0x0400876A RID: 34666
		[Token(Token = "0x400876A")]
		[FieldOffset(Offset = "0x88")]
		private Camera m_Camera;

		// Token: 0x0400876B RID: 34667
		[Token(Token = "0x400876B")]
		[FieldOffset(Offset = "0x90")]
		private UIAvatarInputHandler m_AvatarInput;

		// Token: 0x0400876C RID: 34668
		[Token(Token = "0x400876C")]
		[FieldOffset(Offset = "0x98")]
		private RenderTexture m_DynamicRenderTexture;

		// Token: 0x0400876D RID: 34669
		[Token(Token = "0x400876D")]
		[FieldOffset(Offset = "0xA0")]
		private List<UIAvatarWindowController.TeamAvatar> m_teamAvatars;

		// Token: 0x0400876E RID: 34670
		[Token(Token = "0x400876E")]
		[FieldOffset(Offset = "0xA8")]
		private List<UIGroupMemberInfoController> m_NamePanels;

		// Token: 0x0400876F RID: 34671
		[Token(Token = "0x400876F")]
		[FieldOffset(Offset = "0xB0")]
		private List<GameObject> m_AvatarParticleList;

		// Token: 0x04008770 RID: 34672
		[Token(Token = "0x4008770")]
		[FieldOffset(Offset = "0xB8")]
		private UIModelGroup m_ModelGroup;

		// Token: 0x04008771 RID: 34673
		[Token(Token = "0x4008771")]
		[FieldOffset(Offset = "0xC0")]
		private UIModelAvatar m_ModelAvatar;

		// Token: 0x04008772 RID: 34674
		[Token(Token = "0x4008772")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_AvatarShowCached;

		// Token: 0x04008773 RID: 34675
		[Token(Token = "0x4008773")]
		[FieldOffset(Offset = "0xCC")]
		private EFrontendUIType m_CurrentCameraUIType;

		// Token: 0x04008774 RID: 34676
		[Token(Token = "0x4008774")]
		[FieldOffset(Offset = "0xD0")]
		private GameObject avatarLight;

		// Token: 0x04008775 RID: 34677
		[Token(Token = "0x4008775")]
		[FieldOffset(Offset = "0xD8")]
		private GameObject m_guidePetAcion;

		// Token: 0x04008776 RID: 34678
		[Token(Token = "0x4008776")]
		[FieldOffset(Offset = "0xE0")]
		private GameObject m_AvatarGuideEffect;

		// Token: 0x04008777 RID: 34679
		[Token(Token = "0x4008777")]
		[FieldOffset(Offset = "0xE8")]
		private List<int> m_AvailableTeamNums;

		// Token: 0x04008778 RID: 34680
		[Token(Token = "0x4008778")]
		[FieldOffset(Offset = "0xF0")]
		private bool m_NeedMoveCameraGradual;

		// Token: 0x04008779 RID: 34681
		[Token(Token = "0x4008779")]
		[FieldOffset(Offset = "0xF4")]
		private Vector3 m_TargetCameraPos;

		// Token: 0x0400877A RID: 34682
		[Token(Token = "0x400877A")]
		[FieldOffset(Offset = "0x100")]
		public float CameraMoveMaxDistance;

		// Token: 0x0400877B RID: 34683
		[Token(Token = "0x400877B")]
		[FieldOffset(Offset = "0x108")]
		private Dictionary<int, UIAvatarWindowController.TeamAvatarPos> m_DictPosition;

		// Token: 0x0400877C RID: 34684
		[Token(Token = "0x400877C")]
		[FieldOffset(Offset = "0x110")]
		private Vector3[] m_NamePanelPosArray;

		// Token: 0x0400877D RID: 34685
		[Token(Token = "0x400877D")]
		private const float ipadHeight = 3f;

		// Token: 0x0400877E RID: 34686
		[Token(Token = "0x400877E")]
		private const float ipadWidth = 4f;

		// Token: 0x0400877F RID: 34687
		[Token(Token = "0x400877F")]
		[FieldOffset(Offset = "0x118")]
		private Dictionary<int, Vector3> m_DictOffsetPosition;

		// Token: 0x04008780 RID: 34688
		[Token(Token = "0x4008780")]
		private const float LobbyDefaultAvatarScale = 380f;

		// Token: 0x04008781 RID: 34689
		[Token(Token = "0x4008781")]
		[FieldOffset(Offset = "0x120")]
		private Dictionary<EFrontendUIType, UIAvatarWindowController.AvatarSetting> AVATAR_SETTING;

		// Token: 0x04008782 RID: 34690
		[Token(Token = "0x4008782")]
		[FieldOffset(Offset = "0x128")]
		private Dictionary<EFrontendUIType, UIAvatarWindowController.AvatarPetSetting> AVATAR_PET_SETTING;

		// Token: 0x04008783 RID: 34691
		[Token(Token = "0x4008783")]
		[FieldOffset(Offset = "0x130")]
		private UIModelFriends m_ModelFriends;

		// Token: 0x04008784 RID: 34692
		[Token(Token = "0x4008784")]
		[FieldOffset(Offset = "0x138")]
		private UIModelCollection m_ModelCollection;

		// Token: 0x04008785 RID: 34693
		[Token(Token = "0x4008785")]
		[FieldOffset(Offset = "0x140")]
		private UIModelPVE m_ModelPVE;

		// Token: 0x04008786 RID: 34694
		[Token(Token = "0x4008786")]
		[FieldOffset(Offset = "0x148")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112F83C", Offset = "0x112F83C")]
		private ulong <TargetShowPopMenuAccountID>k__BackingField;

		// Token: 0x020016D6 RID: 5846
		[Token(Token = "0x20016D6")]
		private class TeamAvatar
		{
			// Token: 0x06006BDD RID: 27613 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006BDD")]
			[Address(RVA = "0x141BA58", Offset = "0x141BA58", VA = "0x7BBBC1BA58")]
			public TeamAvatar()
			{
			}

			// Token: 0x04008787 RID: 34695
			[Token(Token = "0x4008787")]
			[FieldOffset(Offset = "0x10")]
			public ulong account_id;

			// Token: 0x04008788 RID: 34696
			[Token(Token = "0x4008788")]
			[FieldOffset(Offset = "0x18")]
			public UIMaleAvatar avatar;

			// Token: 0x04008789 RID: 34697
			[Token(Token = "0x4008789")]
			[FieldOffset(Offset = "0x20")]
			public UIPetAvatar pet_avatar;

			// Token: 0x0400878A RID: 34698
			[Token(Token = "0x400878A")]
			[FieldOffset(Offset = "0x28")]
			public int pos_id;

			// Token: 0x0400878B RID: 34699
			[Token(Token = "0x400878B")]
			[FieldOffset(Offset = "0x2C")]
			public uint avatar_id;

			// Token: 0x0400878C RID: 34700
			[Token(Token = "0x400878C")]
			[FieldOffset(Offset = "0x30")]
			public uint show_weapon_id;

			// Token: 0x0400878D RID: 34701
			[Token(Token = "0x400878D")]
			[FieldOffset(Offset = "0x34")]
			public uint pve_weapon_id;

			// Token: 0x0400878E RID: 34702
			[Token(Token = "0x400878E")]
			[FieldOffset(Offset = "0x38")]
			public uint hand_weapon_id;
		}

		// Token: 0x020016D7 RID: 5847
		[Token(Token = "0x20016D7")]
		private class TeamAvatarPos
		{
			// Token: 0x06006BDE RID: 27614 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006BDE")]
			[Address(RVA = "0x141BA60", Offset = "0x141BA60", VA = "0x7BBBC1BA60")]
			public TeamAvatarPos(Vector3 p, Quaternion r, Vector3 pet_p)
			{
			}

			// Token: 0x0400878F RID: 34703
			[Token(Token = "0x400878F")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 pos;

			// Token: 0x04008790 RID: 34704
			[Token(Token = "0x4008790")]
			[FieldOffset(Offset = "0x1C")]
			public Quaternion rotation;

			// Token: 0x04008791 RID: 34705
			[Token(Token = "0x4008791")]
			[FieldOffset(Offset = "0x2C")]
			public Vector3 pos_pet;
		}

		// Token: 0x020016D8 RID: 5848
		[Token(Token = "0x20016D8")]
		private class AvatarSetting
		{
			// Token: 0x06006BDF RID: 27615 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006BDF")]
			[Address(RVA = "0x141B91C", Offset = "0x141B91C", VA = "0x7BBBC1B91C")]
			public AvatarSetting()
			{
			}

			// Token: 0x04008792 RID: 34706
			[Token(Token = "0x4008792")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 avatar_pos;

			// Token: 0x04008793 RID: 34707
			[Token(Token = "0x4008793")]
			[FieldOffset(Offset = "0x1C")]
			public Vector3 avatar_rotation;

			// Token: 0x04008794 RID: 34708
			[Token(Token = "0x4008794")]
			[FieldOffset(Offset = "0x28")]
			public Vector3 avatar_scale;

			// Token: 0x04008795 RID: 34709
			[Token(Token = "0x4008795")]
			[FieldOffset(Offset = "0x34")]
			public Vector3 camera_pos;

			// Token: 0x04008796 RID: 34710
			[Token(Token = "0x4008796")]
			[FieldOffset(Offset = "0x40")]
			public Vector3 camera_rotaion;

			// Token: 0x04008797 RID: 34711
			[Token(Token = "0x4008797")]
			[FieldOffset(Offset = "0x4C")]
			public bool avatar_input;
		}

		// Token: 0x020016D9 RID: 5849
		[Token(Token = "0x20016D9")]
		private class AvatarPetSetting
		{
			// Token: 0x06006BE0 RID: 27616 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006BE0")]
			[Address(RVA = "0x141B8CC", Offset = "0x141B8CC", VA = "0x7BBBC1B8CC")]
			public AvatarPetSetting(Vector3 pet_pos)
			{
			}

			// Token: 0x04008798 RID: 34712
			[Token(Token = "0x4008798")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 avatar_pos;

			// Token: 0x04008799 RID: 34713
			[Token(Token = "0x4008799")]
			[FieldOffset(Offset = "0x1C")]
			public bool showState;
		}

		// Token: 0x020016DA RID: 5850
		[Token(Token = "0x20016DA")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F0E74", Offset = "0x10F0E74")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06006BE2 RID: 27618 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006BE2")]
			[Address(RVA = "0x141B518", Offset = "0x141B518", VA = "0x7BBBC1B518")]
			public <>c()
			{
			}

			// Token: 0x06006BE3 RID: 27619 RVA: 0x0001E7C8 File Offset: 0x0001C9C8
			[Token(Token = "0x6006BE3")]
			[Address(RVA = "0x141B520", Offset = "0x141B520", VA = "0x7BBBC1B520")]
			internal bool <ShowAvatars>b__89_1(int s)
			{
				return default(bool);
			}

			// Token: 0x06006BE4 RID: 27620 RVA: 0x0001E7E0 File Offset: 0x0001C9E0
			[Token(Token = "0x6006BE4")]
			[Address(RVA = "0x141B52C", Offset = "0x141B52C", VA = "0x7BBBC1B52C")]
			internal bool <ShowAvatars>b__89_0(int s)
			{
				return default(bool);
			}

			// Token: 0x0400879A RID: 34714
			[Token(Token = "0x400879A")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIAvatarWindowController.<>c <>9;

			// Token: 0x0400879B RID: 34715
			[Token(Token = "0x400879B")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<int> <>9__89_1;

			// Token: 0x0400879C RID: 34716
			[Token(Token = "0x400879C")]
			[FieldOffset(Offset = "0x10")]
			public static Predicate<int> <>9__89_0;
		}

		// Token: 0x020016DB RID: 5851
		[Token(Token = "0x20016DB")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F0E84", Offset = "0x10F0E84")]
		private sealed class <>c__DisplayClass90_0
		{
			// Token: 0x06006BE5 RID: 27621 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006BE5")]
			[Address(RVA = "0x141B5F0", Offset = "0x141B5F0", VA = "0x7BBBC1B5F0")]
			public <>c__DisplayClass90_0()
			{
			}

			// Token: 0x06006BE6 RID: 27622 RVA: 0x0001E7F8 File Offset: 0x0001C9F8
			[Token(Token = "0x6006BE6")]
			[Address(RVA = "0x141B5F8", Offset = "0x141B5F8", VA = "0x7BBBC1B5F8")]
			internal bool <OnGroupLeaveNtf>b__0(UIAvatarWindowController.TeamAvatar s)
			{
				return default(bool);
			}

			// Token: 0x0400879D RID: 34717
			[Token(Token = "0x400879D")]
			[FieldOffset(Offset = "0x10")]
			public ulong leaver_id;
		}

		// Token: 0x020016DC RID: 5852
		[Token(Token = "0x20016DC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F0E94", Offset = "0x10F0E94")]
		private sealed class <>c__DisplayClass97_0
		{
			// Token: 0x06006BE7 RID: 27623 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006BE7")]
			[Address(RVA = "0x141B634", Offset = "0x141B634", VA = "0x7BBBC1B634")]
			public <>c__DisplayClass97_0()
			{
			}

			// Token: 0x06006BE8 RID: 27624 RVA: 0x0001E810 File Offset: 0x0001CA10
			[Token(Token = "0x6006BE8")]
			[Address(RVA = "0x141B63C", Offset = "0x141B63C", VA = "0x7BBBC1B63C")]
			internal bool <RefreshTeamatePVEWeapon>b__0(GroupMemberInfo a)
			{
				return default(bool);
			}

			// Token: 0x0400879E RID: 34718
			[Token(Token = "0x400879E")]
			[FieldOffset(Offset = "0x10")]
			public UIAvatarWindowController.TeamAvatar ta;
		}

		// Token: 0x020016DD RID: 5853
		[Token(Token = "0x20016DD")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F0EA4", Offset = "0x10F0EA4")]
		private sealed class <PlayAvatarShowPose>d__98 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006BE9 RID: 27625 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006BE9")]
			[Address(RVA = "0x141B694", Offset = "0x141B694", VA = "0x7BBBC1B694")]
			[DebuggerHidden]
			public <PlayAvatarShowPose>d__98(int <>1__state)
			{
			}

			// Token: 0x06006BEA RID: 27626 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006BEA")]
			[Address(RVA = "0x141B6C0", Offset = "0x141B6C0", VA = "0x7BBBC1B6C0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006BEB RID: 27627 RVA: 0x0001E828 File Offset: 0x0001CA28
			[Token(Token = "0x6006BEB")]
			[Address(RVA = "0x141B6C4", Offset = "0x141B6C4", VA = "0x7BBBC1B6C4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000927 RID: 2343
			// (get) Token: 0x06006BEC RID: 27628 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000927")]
			private object Current
			{
				[Token(Token = "0x6006BEC")]
				[Address(RVA = "0x141B854", Offset = "0x141B854", VA = "0x7BBBC1B854", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006BED RID: 27629 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006BED")]
			[Address(RVA = "0x141B85C", Offset = "0x141B85C", VA = "0x7BBBC1B85C", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000928 RID: 2344
			// (get) Token: 0x06006BEE RID: 27630 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000928")]
			private object Current
			{
				[Token(Token = "0x6006BEE")]
				[Address(RVA = "0x141B8C4", Offset = "0x141B8C4", VA = "0x7BBBC1B8C4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400879F RID: 34719
			[Token(Token = "0x400879F")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040087A0 RID: 34720
			[Token(Token = "0x40087A0")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040087A1 RID: 34721
			[Token(Token = "0x40087A1")]
			[FieldOffset(Offset = "0x20")]
			public UIAvatarWindowController <>4__this;

			// Token: 0x040087A2 RID: 34722
			[Token(Token = "0x40087A2")]
			[FieldOffset(Offset = "0x28")]
			public UIMaleAvatar avatar;

			// Token: 0x040087A3 RID: 34723
			[Token(Token = "0x40087A3")]
			[FieldOffset(Offset = "0x30")]
			public float seconds;

			// Token: 0x040087A4 RID: 34724
			[Token(Token = "0x40087A4")]
			[FieldOffset(Offset = "0x34")]
			private EFrontendUIType <preCamera>5__2;
		}

		// Token: 0x020016DE RID: 5854
		[Token(Token = "0x20016DE")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F0EB4", Offset = "0x10F0EB4")]
		private sealed class <>c__DisplayClass103_0
		{
			// Token: 0x06006BEF RID: 27631 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006BEF")]
			[Address(RVA = "0x141B538", Offset = "0x141B538", VA = "0x7BBBC1B538")]
			public <>c__DisplayClass103_0()
			{
			}

			// Token: 0x06006BF0 RID: 27632 RVA: 0x0001E840 File Offset: 0x0001CA40
			[Token(Token = "0x6006BF0")]
			[Address(RVA = "0x141B540", Offset = "0x141B540", VA = "0x7BBBC1B540")]
			internal bool <OnGroupReadyNtf>b__0(UIAvatarWindowController.TeamAvatar s)
			{
				return default(bool);
			}

			// Token: 0x040087A5 RID: 34725
			[Token(Token = "0x40087A5")]
			[FieldOffset(Offset = "0x10")]
			public GroupMemberInfo mem;
		}

		// Token: 0x020016DF RID: 5855
		[Token(Token = "0x20016DF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F0EC4", Offset = "0x10F0EC4")]
		private sealed class <>c__DisplayClass104_0
		{
			// Token: 0x06006BF1 RID: 27633 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006BF1")]
			[Address(RVA = "0x141B594", Offset = "0x141B594", VA = "0x7BBBC1B594")]
			public <>c__DisplayClass104_0()
			{
			}

			// Token: 0x06006BF2 RID: 27634 RVA: 0x0001E858 File Offset: 0x0001CA58
			[Token(Token = "0x6006BF2")]
			[Address(RVA = "0x141B59C", Offset = "0x141B59C", VA = "0x7BBBC1B59C")]
			internal bool <onGroupStopNtf>b__0(UIAvatarWindowController.TeamAvatar s)
			{
				return default(bool);
			}

			// Token: 0x040087A6 RID: 34726
			[Token(Token = "0x40087A6")]
			[FieldOffset(Offset = "0x10")]
			public GroupMemberInfo stopper;
		}
	}
}
