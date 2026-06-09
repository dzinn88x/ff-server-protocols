using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001BD8 RID: 7128
	[Token(Token = "0x2001BD8")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FB004", Offset = "0x10FB004")]
	public class UIWeaponSkinLobbyMainController : UINavigationController, IEasyList, IUIModelDataChangeObserver
	{
		// Token: 0x06009A2B RID: 39467 RVA: 0x00028968 File Offset: 0x00026B68
		[Token(Token = "0x6009A2B")]
		[Address(RVA = "0x1691930", Offset = "0x1691930", VA = "0x7BBBE91930")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009A2C RID: 39468 RVA: 0x00028980 File Offset: 0x00026B80
		[Token(Token = "0x6009A2C")]
		[Address(RVA = "0x1691980", Offset = "0x1691980", VA = "0x7BBBE91980")]
		public CollectionDataManager.ECollectionWeaponType GetWeaponType()
		{
			return CollectionDataManager.ECollectionWeaponType.fist;
		}

		// Token: 0x06009A2D RID: 39469 RVA: 0x00028998 File Offset: 0x00026B98
		[Token(Token = "0x6009A2D")]
		[Address(RVA = "0x1691988", Offset = "0x1691988", VA = "0x7BBBE91988")]
		public uint GetWeaponId()
		{
			return 0U;
		}

		// Token: 0x06009A2E RID: 39470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A2E")]
		[Address(RVA = "0x1691990", Offset = "0x1691990", VA = "0x7BBBE91990")]
		private void RefreshLobbyWeaponTips()
		{
		}

		// Token: 0x06009A2F RID: 39471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A2F")]
		[Address(RVA = "0x1691B4C", Offset = "0x1691B4C", VA = "0x7BBBE91B4C")]
		public void RefreshDictTips()
		{
		}

		// Token: 0x06009A30 RID: 39472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A30")]
		[Address(RVA = "0x1691F5C", Offset = "0x1691F5C", VA = "0x7BBBE91F5C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009A31 RID: 39473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A31")]
		[Address(RVA = "0x1693120", Offset = "0x1693120", VA = "0x7BBBE93120")]
		private void OnWeaponSkinUpgradeInfoIconClick()
		{
		}

		// Token: 0x06009A32 RID: 39474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A32")]
		[Address(RVA = "0x1693830", Offset = "0x1693830", VA = "0x7BBBE93830")]
		private void OnDownloadBtnClick()
		{
		}

		// Token: 0x06009A33 RID: 39475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A33")]
		[Address(RVA = "0x1693B9C", Offset = "0x1693B9C", VA = "0x7BBBE93B9C")]
		public void SetHotFixTextShow(bool show)
		{
		}

		// Token: 0x06009A34 RID: 39476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A34")]
		[Address(RVA = "0x1693DD4", Offset = "0x1693DD4", VA = "0x7BBBE93DD4", Slot = "23")]
		public override void BeforeScreenshot()
		{
		}

		// Token: 0x06009A35 RID: 39477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A35")]
		[Address(RVA = "0x1694EE4", Offset = "0x1694EE4", VA = "0x7BBBE94EE4", Slot = "24")]
		public override void AfterScreenshot()
		{
		}

		// Token: 0x06009A36 RID: 39478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A36")]
		[Address(RVA = "0x1694FDC", Offset = "0x1694FDC", VA = "0x7BBBE94FDC")]
		private void OnLevelUpClick()
		{
		}

		// Token: 0x06009A37 RID: 39479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A37")]
		[Address(RVA = "0x1694090", Offset = "0x1694090", VA = "0x7BBBE94090")]
		private void CreateSharePreviewModel()
		{
		}

		// Token: 0x06009A38 RID: 39480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A38")]
		[Address(RVA = "0x1695338", Offset = "0x1695338", VA = "0x7BBBE95338")]
		private void OnShareClick()
		{
		}

		// Token: 0x06009A39 RID: 39481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A39")]
		[Address(RVA = "0x16955B4", Offset = "0x16955B4", VA = "0x7BBBE955B4")]
		protected void Ondraging(GameObject go, Vector2 delta)
		{
		}

		// Token: 0x06009A3A RID: 39482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A3A")]
		[Address(RVA = "0x16956F8", Offset = "0x16956F8", VA = "0x7BBBE956F8")]
		private void OndragStart(GameObject gameObject)
		{
		}

		// Token: 0x06009A3B RID: 39483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A3B")]
		[Address(RVA = "0x1695700", Offset = "0x1695700", VA = "0x7BBBE95700")]
		private void OndragEnd(GameObject gameObject)
		{
		}

		// Token: 0x06009A3C RID: 39484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A3C")]
		[Address(RVA = "0x16957A0", Offset = "0x16957A0", VA = "0x7BBBE957A0")]
		private void OnBtnSwitchClick()
		{
		}

		// Token: 0x06009A3D RID: 39485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A3D")]
		[Address(RVA = "0x169661C", Offset = "0x169661C", VA = "0x7BBBE9661C")]
		public void SetSwithBtnVisble(bool need_show, UIWeaponSkinLobbyMainController.SwitchType type = UIWeaponSkinLobbyMainController.SwitchType.Gun)
		{
		}

		// Token: 0x06009A3E RID: 39486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A3E")]
		[Address(RVA = "0x1695FE4", Offset = "0x1695FE4", VA = "0x7BBBE95FE4")]
		private void SwithChange(UIWeaponSkinLobbyMainController.SwitchType type)
		{
		}

		// Token: 0x06009A3F RID: 39487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009A3F")]
		[Address(RVA = "0x169572C", Offset = "0x169572C", VA = "0x7BBBE9572C")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1144FD8", Offset = "0x1144FD8")]
		private IEnumerator ResetWeapon()
		{
			return null;
		}

		// Token: 0x06009A40 RID: 39488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A40")]
		[Address(RVA = "0x16966AC", Offset = "0x16966AC", VA = "0x7BBBE966AC")]
		private void OnWeaponSkillClick()
		{
		}

		// Token: 0x06009A41 RID: 39489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A41")]
		[Address(RVA = "0x169674C", Offset = "0x169674C", VA = "0x7BBBE9674C")]
		private void OnBtnZoomClick()
		{
		}

		// Token: 0x06009A42 RID: 39490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A42")]
		[Address(RVA = "0x1696BC4", Offset = "0x1696BC4", VA = "0x7BBBE96BC4")]
		private void OnShowIconBtnClick()
		{
		}

		// Token: 0x06009A43 RID: 39491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A43")]
		[Address(RVA = "0x1696D90", Offset = "0x1696D90", VA = "0x7BBBE96D90")]
		public void ShowIPTag()
		{
		}

		// Token: 0x06009A44 RID: 39492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A44")]
		[Address(RVA = "0x1696FC0", Offset = "0x1696FC0", VA = "0x7BBBE96FC0")]
		private void OnNotificationIconBtnClick()
		{
		}

		// Token: 0x06009A45 RID: 39493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A45")]
		[Address(RVA = "0x169718C", Offset = "0x169718C", VA = "0x7BBBE9718C")]
		private void ShowNotReachRankItemUseLevelTips(uint itemID)
		{
		}

		// Token: 0x06009A46 RID: 39494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A46")]
		[Address(RVA = "0x16974B0", Offset = "0x16974B0", VA = "0x7BBBE974B0")]
		private void OnEquipBtnClick()
		{
		}

		// Token: 0x06009A47 RID: 39495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A47")]
		[Address(RVA = "0x169757C", Offset = "0x169757C", VA = "0x7BBBE9757C")]
		private void OnShownBtnClick()
		{
		}

		// Token: 0x06009A48 RID: 39496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A48")]
		[Address(RVA = "0x1697750", Offset = "0x1697750", VA = "0x7BBBE97750")]
		public void OnBtnNotificationClick()
		{
		}

		// Token: 0x06009A49 RID: 39497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A49")]
		[Address(RVA = "0x16977F8", Offset = "0x16977F8", VA = "0x7BBBE977F8")]
		protected void SetEquipBtnStatus(bool isEquiped = false)
		{
		}

		// Token: 0x06009A4A RID: 39498 RVA: 0x000289B0 File Offset: 0x00026BB0
		[Token(Token = "0x6009A4A")]
		[Address(RVA = "0x16979D8", Offset = "0x16979D8", VA = "0x7BBBE979D8")]
		private bool HaveItems()
		{
			return default(bool);
		}

		// Token: 0x06009A4B RID: 39499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A4B")]
		[Address(RVA = "0x1697A5C", Offset = "0x1697A5C", VA = "0x7BBBE97A5C")]
		protected void SetShowBtnStatus(bool canBeShowed, bool isShowed)
		{
		}

		// Token: 0x06009A4C RID: 39500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A4C")]
		[Address(RVA = "0x1697C40", Offset = "0x1697C40", VA = "0x7BBBE97C40")]
		public void SetNotificationBtnVisble(bool need_show)
		{
		}

		// Token: 0x06009A4D RID: 39501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A4D")]
		[Address(RVA = "0x1697D68", Offset = "0x1697D68", VA = "0x7BBBE97D68")]
		private void RrefreshMainUI()
		{
		}

		// Token: 0x06009A4E RID: 39502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A4E")]
		[Address(RVA = "0x1698AE0", Offset = "0x1698AE0", VA = "0x7BBBE98AE0")]
		private void RefreshCurrentInfo(CollectionDataManager.ECollectionWeaponType type, uint weaponinfoid, uint weaponskinid, WeaponSkinBaseInfo weapondata)
		{
		}

		// Token: 0x06009A4F RID: 39503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A4F")]
		[Address(RVA = "0x1698428", Offset = "0x1698428", VA = "0x7BBBE98428")]
		private void RefreshMainSkin(uint id)
		{
		}

		// Token: 0x06009A50 RID: 39504 RVA: 0x000289C8 File Offset: 0x00026BC8
		[Token(Token = "0x6009A50")]
		[Address(RVA = "0x1698260", Offset = "0x1698260", VA = "0x7BBBE98260")]
		private int CalAllWeaponSkins()
		{
			return 0;
		}

		// Token: 0x06009A51 RID: 39505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A51")]
		[Address(RVA = "0x1692DE4", Offset = "0x1692DE4", VA = "0x7BBBE92DE4")]
		public void DisplayWeaponPropertyScore(bool show)
		{
		}

		// Token: 0x06009A52 RID: 39506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A52")]
		[Address(RVA = "0x1699778", Offset = "0x1699778", VA = "0x7BBBE99778")]
		private void ForeceRefreshWeaponData()
		{
		}

		// Token: 0x06009A53 RID: 39507 RVA: 0x000289E0 File Offset: 0x00026BE0
		[Token(Token = "0x6009A53")]
		[Address(RVA = "0x169978C", Offset = "0x169978C", VA = "0x7BBBE9978C")]
		private bool UpdateWindowParm(UINavigationData navigationData)
		{
			return default(bool);
		}

		// Token: 0x06009A54 RID: 39508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A54")]
		[Address(RVA = "0x16998A4", Offset = "0x16998A4", VA = "0x7BBBE998A4", Slot = "28")]
		public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
		{
		}

		// Token: 0x06009A55 RID: 39509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A55")]
		[Address(RVA = "0x169A094", Offset = "0x169A094", VA = "0x7BBBE9A094", Slot = "29")]
		public override void OnNavigationClosed()
		{
		}

		// Token: 0x06009A56 RID: 39510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A56")]
		[Address(RVA = "0x1692AD0", Offset = "0x1692AD0", VA = "0x7BBBE92AD0")]
		private void InitAllModelResource()
		{
		}

		// Token: 0x06009A57 RID: 39511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A57")]
		[Address(RVA = "0x169A0C0", Offset = "0x169A0C0", VA = "0x7BBBE9A0C0")]
		private void ClearAllModelResource()
		{
		}

		// Token: 0x06009A58 RID: 39512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A58")]
		[Address(RVA = "0x169A30C", Offset = "0x169A30C", VA = "0x7BBBE9A30C", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06009A59 RID: 39513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A59")]
		[Address(RVA = "0x169A334", Offset = "0x169A334", VA = "0x7BBBE9A334", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06009A5A RID: 39514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A5A")]
		[Address(RVA = "0x169A72C", Offset = "0x169A72C", VA = "0x7BBBE9A72C")]
		private void OnRefreshDetail(params object[] data)
		{
		}

		// Token: 0x06009A5B RID: 39515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A5B")]
		[Address(RVA = "0x169B108", Offset = "0x169B108", VA = "0x7BBBE9B108")]
		private void OnRefreshEventTrigger(params object[] data)
		{
		}

		// Token: 0x06009A5C RID: 39516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A5C")]
		[Address(RVA = "0x169B1C0", Offset = "0x169B1C0", VA = "0x7BBBE9B1C0")]
		private void OnRefreshWeaponSkin(params object[] data)
		{
		}

		// Token: 0x06009A5D RID: 39517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A5D")]
		[Address(RVA = "0x169B1CC", Offset = "0x169B1CC", VA = "0x7BBBE9B1CC", Slot = "40")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06009A5E RID: 39518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A5E")]
		[Address(RVA = "0x169A8F4", Offset = "0x169A8F4", VA = "0x7BBBE9A8F4")]
		private void RefreshFirstType(CollectionDataManager.ECollectionWeaponType type)
		{
		}

		// Token: 0x06009A5F RID: 39519 RVA: 0x000289F8 File Offset: 0x00026BF8
		[Token(Token = "0x6009A5F")]
		[Address(RVA = "0x169B1FC", Offset = "0x169B1FC", VA = "0x7BBBE9B1FC", Slot = "33")]
		public override EFrontendUIType GetBackgroundImageType()
		{
			return EFrontendUIType.Lobby;
		}

		// Token: 0x06009A60 RID: 39520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A60")]
		[Address(RVA = "0x1699F4C", Offset = "0x1699F4C", VA = "0x7BBBE99F4C")]
		private void RefreshSecondType(uint id)
		{
		}

		// Token: 0x06009A61 RID: 39521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009A61")]
		[Address(RVA = "0x169900C", Offset = "0x169900C", VA = "0x7BBBE9900C")]
		private List<WeaponSkinBaseInfo> ReArrangeList(List<WeaponSkinBaseInfo> list)
		{
			return null;
		}

		// Token: 0x06009A62 RID: 39522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A62")]
		[Address(RVA = "0x16993CC", Offset = "0x16993CC", VA = "0x7BBBE993CC")]
		private void RefreshThirdType(uint weaponid, WeaponSkinBaseInfo data)
		{
		}

		// Token: 0x06009A63 RID: 39523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A63")]
		[Address(RVA = "0x16960F8", Offset = "0x16960F8", VA = "0x7BBBE960F8")]
		private void RrefreshPreviewWeapon(uint weaponid, bool needrefresh = true)
		{
		}

		// Token: 0x06009A64 RID: 39524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009A64")]
		[Address(RVA = "0x169D4FC", Offset = "0x169D4FC", VA = "0x7BBBE9D4FC")]
		private UIMaleAvatar CreateAvatar(List<uint> idlist, Vector3 scale, Vector3 pos, bool playSpecial, bool changanim = true, int doubleAnimid = 0, string resSpecial = "", string resIdle = "", bool uselight = true)
		{
			return null;
		}

		// Token: 0x06009A65 RID: 39525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A65")]
		[Address(RVA = "0x1695AB4", Offset = "0x1695AB4", VA = "0x7BBBE95AB4")]
		private void CreatePreviewAvatarWithWeapon(List<uint> idlist, uint weaponid)
		{
		}

		// Token: 0x06009A66 RID: 39526 RVA: 0x00028A10 File Offset: 0x00026C10
		[Token(Token = "0x6009A66")]
		[Address(RVA = "0x169D5F8", Offset = "0x169D5F8", VA = "0x7BBBE9D5F8")]
		private bool CheckIsDualWield(uint weaponid)
		{
			return default(bool);
		}

		// Token: 0x06009A67 RID: 39527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A67")]
		[Address(RVA = "0x169517C", Offset = "0x169517C", VA = "0x7BBBE9517C")]
		private void AutoModifyPreviewModelAccordingToResolution(ref GameObject go, bool useY = false, float scaley = 0.5f, bool isAvatar = false)
		{
		}

		// Token: 0x06009A68 RID: 39528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A68")]
		[Address(RVA = "0x169DD4C", Offset = "0x169DD4C", VA = "0x7BBBE9DD4C")]
		private void AutoShift3DPreview(ref GameObject go, float scalex, float scaley, bool useY)
		{
		}

		// Token: 0x06009A69 RID: 39529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A69")]
		[Address(RVA = "0x169D694", Offset = "0x169D694", VA = "0x7BBBE9D694")]
		private void AutoGen3DPreviewCollider(GameObject go, bool isAvatar = false)
		{
		}

		// Token: 0x06009A6A RID: 39530 RVA: 0x00028A28 File Offset: 0x00026C28
		[Token(Token = "0x6009A6A")]
		[Address(RVA = "0x169E954", Offset = "0x169E954", VA = "0x7BBBE9E954")]
		private bool CheckInvaildCollider(Renderer render)
		{
			return default(bool);
		}

		// Token: 0x06009A6B RID: 39531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A6B")]
		[Address(RVA = "0x1699BAC", Offset = "0x1699BAC", VA = "0x7BBBE99BAC")]
		private void ClearAllUI()
		{
		}

		// Token: 0x06009A6C RID: 39532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A6C")]
		[Address(RVA = "0x169B368", Offset = "0x169B368", VA = "0x7BBBE9B368")]
		private void Refresh3dWeapon(ResourceID model_id)
		{
		}

		// Token: 0x06009A6D RID: 39533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A6D")]
		[Address(RVA = "0x169EAF4", Offset = "0x169EAF4", VA = "0x7BBBE9EAF4")]
		private void SavePreviewWeaponTransform()
		{
		}

		// Token: 0x06009A6E RID: 39534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A6E")]
		[Address(RVA = "0x169EC30", Offset = "0x169EC30", VA = "0x7BBBE9EC30")]
		private void ResetPreviewWeaponTransform()
		{
		}

		// Token: 0x06009A6F RID: 39535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A6F")]
		[Address(RVA = "0x169EDB4", Offset = "0x169EDB4", VA = "0x7BBBE9EDB4")]
		private void UpdateLevelUpVfx()
		{
		}

		// Token: 0x06009A70 RID: 39536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A70")]
		[Address(RVA = "0x169BDF4", Offset = "0x169BDF4", VA = "0x7BBBE9BDF4")]
		private void refrehItemInfo(uint itemid)
		{
		}

		// Token: 0x06009A71 RID: 39537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A71")]
		[Address(RVA = "0x169C404", Offset = "0x169C404", VA = "0x7BBBE9C404")]
		private void RefreshWeaponUI(uint weaponid, WeaponSkinData lData, bool needrefresh = true)
		{
		}

		// Token: 0x06009A72 RID: 39538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A72")]
		[Address(RVA = "0x169B204", Offset = "0x169B204", VA = "0x7BBBE9B204")]
		private void ShowInAbWeapon(uint weaponid, uint wid)
		{
		}

		// Token: 0x06009A73 RID: 39539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A73")]
		[Address(RVA = "0x169F97C", Offset = "0x169F97C", VA = "0x7BBBE9F97C")]
		private void ShowPropertyContainer(bool isVisible, UIWeaponSkinLobbyMainController.PropertyType pType)
		{
		}

		// Token: 0x06009A74 RID: 39540 RVA: 0x00028A40 File Offset: 0x00026C40
		[Token(Token = "0x6009A74")]
		[Address(RVA = "0x169FBE8", Offset = "0x169FBE8", VA = "0x7BBBE9FBE8")]
		public bool SetWeaponPvpPropertyScoreVisble(bool isVisble)
		{
			return default(bool);
		}

		// Token: 0x06009A75 RID: 39541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A75")]
		[Address(RVA = "0x169F1B8", Offset = "0x169F1B8", VA = "0x7BBBE9F1B8")]
		public void RefreshWeaponPropertyScore(uint itemid)
		{
		}

		// Token: 0x06009A76 RID: 39542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A76")]
		[Address(RVA = "0x169F84C", Offset = "0x169F84C", VA = "0x7BBBE9F84C")]
		public void SetWeaponSkinUpgradeInfoIconVisble(bool need_show)
		{
		}

		// Token: 0x06009A77 RID: 39543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A77")]
		[Address(RVA = "0x169FCA0", Offset = "0x169FCA0", VA = "0x7BBBE9FCA0")]
		private void RefreshScoreGrid()
		{
		}

		// Token: 0x06009A78 RID: 39544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A78")]
		[Address(RVA = "0x169FD24", Offset = "0x169FD24", VA = "0x7BBBE9FD24")]
		private void OnPvpToggleClick()
		{
		}

		// Token: 0x06009A79 RID: 39545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A79")]
		[Address(RVA = "0x169FD30", Offset = "0x169FD30", VA = "0x7BBBE9FD30")]
		private void OnPveToggleClick()
		{
		}

		// Token: 0x06009A7A RID: 39546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009A7A")]
		[Address(RVA = "0x169FD3C", Offset = "0x169FD3C", VA = "0x7BBBE9FD3C", Slot = "39")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06009A7B RID: 39547 RVA: 0x00028A58 File Offset: 0x00026C58
		[Token(Token = "0x6009A7B")]
		[Address(RVA = "0x169FE7C", Offset = "0x169FE7C", VA = "0x7BBBE9FE7C", Slot = "42")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06009A7C RID: 39548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A7C")]
		[Address(RVA = "0x169FF00", Offset = "0x169FF00", VA = "0x7BBBE9FF00")]
		private void RefreshEquipBtn()
		{
		}

		// Token: 0x06009A7D RID: 39549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A7D")]
		[Address(RVA = "0x16A00B8", Offset = "0x16A00B8", VA = "0x7BBBEA00B8")]
		private void RefreshShowBtn()
		{
		}

		// Token: 0x06009A7E RID: 39550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A7E")]
		[Address(RVA = "0x16A0170", Offset = "0x16A0170", VA = "0x7BBBEA0170", Slot = "41")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06009A7F RID: 39551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A7F")]
		[Address(RVA = "0x16A0354", Offset = "0x16A0354", VA = "0x7BBBEA0354")]
		public UIWeaponSkinLobbyMainController()
		{
		}

		// Token: 0x06009A80 RID: 39552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A80")]
		[Address(RVA = "0x16A0864", Offset = "0x16A0864", VA = "0x7BBBEA0864")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114503C", Offset = "0x114503C")]
		private void <OnShareClick>b__53_0()
		{
		}

		// Token: 0x0400A11C RID: 41244
		[Token(Token = "0x400A11C")]
		[FieldOffset(Offset = "0xB0")]
		private Dictionary<CollectionDataManager.ECollectionWeaponType, string> m_DictWeaponType2Text;

		// Token: 0x0400A11D RID: 41245
		[Token(Token = "0x400A11D")]
		[FieldOffset(Offset = "0xB8")]
		private UIWeaponSkinLobbyMainController.PropertyType m_PropertyType;

		// Token: 0x0400A11E RID: 41246
		[Token(Token = "0x400A11E")]
		[FieldOffset(Offset = "0xBC")]
		private CollectionDataManager.ECollectionWeaponType m_WeaponType;

		// Token: 0x0400A11F RID: 41247
		[Token(Token = "0x400A11F")]
		[FieldOffset(Offset = "0xC0")]
		private uint m_WeaponInfoId;

		// Token: 0x0400A120 RID: 41248
		[Token(Token = "0x400A120")]
		[FieldOffset(Offset = "0xC4")]
		private uint m_WeaponSkinId;

		// Token: 0x0400A121 RID: 41249
		[Token(Token = "0x400A121")]
		[FieldOffset(Offset = "0xC8")]
		private WeaponSkinBaseInfo m_WeaponData;

		// Token: 0x0400A122 RID: 41250
		[Token(Token = "0x400A122")]
		private const string m_Parenta = "FirstGrid";

		// Token: 0x0400A123 RID: 41251
		[Token(Token = "0x400A123")]
		private const string m_Parentb = "SecondGrid";

		// Token: 0x0400A124 RID: 41252
		[Token(Token = "0x400A124")]
		private const string m_Parentc = "ThirdGrid";

		// Token: 0x0400A125 RID: 41253
		[Token(Token = "0x400A125")]
		[FieldOffset(Offset = "0xD0")]
		private UIModelCollection m_ModelCollection;

		// Token: 0x0400A126 RID: 41254
		[Token(Token = "0x400A126")]
		[FieldOffset(Offset = "0xD8")]
		private UIWeaponSkinLobbyMainView m_View;

		// Token: 0x0400A127 RID: 41255
		[Token(Token = "0x400A127")]
		[FieldOffset(Offset = "0xE0")]
		private UIPVEWeaponPropertyController m_SelectedWeaponPveProperty;

		// Token: 0x0400A128 RID: 41256
		[Token(Token = "0x400A128")]
		[FieldOffset(Offset = "0xE8")]
		private UIWeaponKillNotificationItemController m_KillNotification;

		// Token: 0x0400A129 RID: 41257
		[Token(Token = "0x400A129")]
		[FieldOffset(Offset = "0xF0")]
		private UIWeaponSkillItemController m_skillItem;

		// Token: 0x0400A12A RID: 41258
		[Token(Token = "0x400A12A")]
		[FieldOffset(Offset = "0xF8")]
		private uint m_WeaponScoreOpen;

		// Token: 0x0400A12B RID: 41259
		[Token(Token = "0x400A12B")]
		[FieldOffset(Offset = "0x100")]
		private GameObject m_ItemCameraGo;

		// Token: 0x0400A12C RID: 41260
		[Token(Token = "0x400A12C")]
		[FieldOffset(Offset = "0x108")]
		private Camera m_ItemCamera;

		// Token: 0x0400A12D RID: 41261
		[Token(Token = "0x400A12D")]
		[FieldOffset(Offset = "0x110")]
		private GameObject m_MixCameraGo;

		// Token: 0x0400A12E RID: 41262
		[Token(Token = "0x400A12E")]
		[FieldOffset(Offset = "0x118")]
		private Camera m_MixCamera;

		// Token: 0x0400A12F RID: 41263
		[Token(Token = "0x400A12F")]
		[FieldOffset(Offset = "0x120")]
		private GameObject m_ShareCamera;

		// Token: 0x0400A130 RID: 41264
		[Token(Token = "0x400A130")]
		[FieldOffset(Offset = "0x128")]
		private ResourceID m_CurrentWeaponResourceId;

		// Token: 0x0400A131 RID: 41265
		[Token(Token = "0x400A131")]
		[FieldOffset(Offset = "0x130")]
		private GameObject m_PreviewWeaponObj;

		// Token: 0x0400A132 RID: 41266
		[Token(Token = "0x400A132")]
		private const float m_RotateRate = 0.5f;

		// Token: 0x0400A133 RID: 41267
		[Token(Token = "0x400A133")]
		[FieldOffset(Offset = "0x138")]
		private GameObject m_PreviewShareWeaponObj;

		// Token: 0x0400A134 RID: 41268
		[Token(Token = "0x400A134")]
		[FieldOffset(Offset = "0x140")]
		private Vector3 m_PreviewSavePos;

		// Token: 0x0400A135 RID: 41269
		[Token(Token = "0x400A135")]
		[FieldOffset(Offset = "0x14C")]
		private Quaternion m_PreviewSaveRotation;

		// Token: 0x0400A136 RID: 41270
		[Token(Token = "0x400A136")]
		[FieldOffset(Offset = "0x15C")]
		private Vector3 m_PreviewSaveScale;

		// Token: 0x0400A137 RID: 41271
		[Token(Token = "0x400A137")]
		[FieldOffset(Offset = "0x168")]
		private UIWeaponZoomInController m_ZoomInController;

		// Token: 0x0400A138 RID: 41272
		[Token(Token = "0x400A138")]
		[FieldOffset(Offset = "0x170")]
		private UIMaleAvatar m_PreviewAvatar;

		// Token: 0x0400A139 RID: 41273
		[Token(Token = "0x400A139")]
		[FieldOffset(Offset = "0x178")]
		private UIWeaponSkinLobbyMainController.SwitchType m_Swithtype;

		// Token: 0x0400A13A RID: 41274
		[Token(Token = "0x400A13A")]
		[FieldOffset(Offset = "0x17C")]
		private bool m_HasInit;

		// Token: 0x0400A13B RID: 41275
		[Token(Token = "0x400A13B")]
		[FieldOffset(Offset = "0x17D")]
		private bool m_RefreshSkinMain;

		// Token: 0x0400A13C RID: 41276
		[Token(Token = "0x400A13C")]
		[FieldOffset(Offset = "0x180")]
		private uint m_RefreshSkinId;

		// Token: 0x0400A13D RID: 41277
		[Token(Token = "0x400A13D")]
		[FieldOffset(Offset = "0x184")]
		private Quaternion m_StopPos;

		// Token: 0x0400A13E RID: 41278
		[Token(Token = "0x400A13E")]
		[FieldOffset(Offset = "0x194")]
		private bool m_CanRefrehWeaponSkin;

		// Token: 0x0400A13F RID: 41279
		[Token(Token = "0x400A13F")]
		[FieldOffset(Offset = "0x198")]
		public Dictionary<CollectionDataManager.ECollectionWeaponType, bool> m_DictCollctionTypeToTips;

		// Token: 0x0400A140 RID: 41280
		[Token(Token = "0x400A140")]
		[FieldOffset(Offset = "0x1A0")]
		public Dictionary<uint, bool> m_DictWeaponIdToTips;

		// Token: 0x0400A141 RID: 41281
		[Token(Token = "0x400A141")]
		[FieldOffset(Offset = "0x1A8")]
		public Dictionary<uint, bool> m_DictWeaponSkinIdToTips;

		// Token: 0x02001BD9 RID: 7129
		[Token(Token = "0x2001BD9")]
		public enum PropertyType
		{
			// Token: 0x0400A143 RID: 41283
			[Token(Token = "0x400A143")]
			None,
			// Token: 0x0400A144 RID: 41284
			[Token(Token = "0x400A144")]
			Pve,
			// Token: 0x0400A145 RID: 41285
			[Token(Token = "0x400A145")]
			Pvp
		}

		// Token: 0x02001BDA RID: 7130
		[Token(Token = "0x2001BDA")]
		public enum SwitchType
		{
			// Token: 0x0400A147 RID: 41287
			[Token(Token = "0x400A147")]
			Gun,
			// Token: 0x0400A148 RID: 41288
			[Token(Token = "0x400A148")]
			Person
		}

		// Token: 0x02001BDB RID: 7131
		[Token(Token = "0x2001BDB")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FB03C", Offset = "0x10FB03C")]
		private sealed class <ResetWeapon>d__60 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06009A81 RID: 39553 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009A81")]
			[Address(RVA = "0x2216D2C", Offset = "0x2216D2C", VA = "0x7BBCA16D2C")]
			[DebuggerHidden]
			public <ResetWeapon>d__60(int <>1__state)
			{
			}

			// Token: 0x06009A82 RID: 39554 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009A82")]
			[Address(RVA = "0x2216D58", Offset = "0x2216D58", VA = "0x7BBCA16D58", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06009A83 RID: 39555 RVA: 0x00028A70 File Offset: 0x00026C70
			[Token(Token = "0x6009A83")]
			[Address(RVA = "0x2216D5C", Offset = "0x2216D5C", VA = "0x7BBCA16D5C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000A52 RID: 2642
			// (get) Token: 0x06009A84 RID: 39556 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A52")]
			private object Current
			{
				[Token(Token = "0x6009A84")]
				[Address(RVA = "0x2216FB4", Offset = "0x2216FB4", VA = "0x7BBCA16FB4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06009A85 RID: 39557 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009A85")]
			[Address(RVA = "0x2216FBC", Offset = "0x2216FBC", VA = "0x7BBCA16FBC", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000A53 RID: 2643
			// (get) Token: 0x06009A86 RID: 39558 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A53")]
			private object Current
			{
				[Token(Token = "0x6009A86")]
				[Address(RVA = "0x2217024", Offset = "0x2217024", VA = "0x7BBCA17024", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400A149 RID: 41289
			[Token(Token = "0x400A149")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400A14A RID: 41290
			[Token(Token = "0x400A14A")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400A14B RID: 41291
			[Token(Token = "0x400A14B")]
			[FieldOffset(Offset = "0x20")]
			public UIWeaponSkinLobbyMainController <>4__this;

			// Token: 0x0400A14C RID: 41292
			[Token(Token = "0x400A14C")]
			[FieldOffset(Offset = "0x28")]
			private Quaternion <lerproate>5__2;

			// Token: 0x0400A14D RID: 41293
			[Token(Token = "0x400A14D")]
			[FieldOffset(Offset = "0x38")]
			private float <time>5__3;
		}

		// Token: 0x02001BDC RID: 7132
		[Token(Token = "0x2001BDC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FB04C", Offset = "0x10FB04C")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06009A88 RID: 39560 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009A88")]
			[Address(RVA = "0x2216ACC", Offset = "0x2216ACC", VA = "0x7BBCA16ACC")]
			public <>c()
			{
			}

			// Token: 0x06009A89 RID: 39561 RVA: 0x00028A88 File Offset: 0x00026C88
			[Token(Token = "0x6009A89")]
			[Address(RVA = "0x2216AD4", Offset = "0x2216AD4", VA = "0x7BBCA16AD4")]
			internal int <RrefreshMainUI>b__74_0(CollectionDataManager.ECollectionWeaponType a, CollectionDataManager.ECollectionWeaponType b)
			{
				return 0;
			}

			// Token: 0x06009A8A RID: 39562 RVA: 0x00028AA0 File Offset: 0x00026CA0
			[Token(Token = "0x6009A8A")]
			[Address(RVA = "0x2216B9C", Offset = "0x2216B9C", VA = "0x7BBCA16B9C")]
			internal int <RefreshCurrentInfo>b__75_0(CollectionDataManager.ECollectionWeaponType a, CollectionDataManager.ECollectionWeaponType b)
			{
				return 0;
			}

			// Token: 0x06009A8B RID: 39563 RVA: 0x00028AB8 File Offset: 0x00026CB8
			[Token(Token = "0x6009A8B")]
			[Address(RVA = "0x2216C64", Offset = "0x2216C64", VA = "0x7BBCA16C64")]
			internal int <RefreshMainSkin>b__76_0(CollectionDataManager.ECollectionWeaponType a, CollectionDataManager.ECollectionWeaponType b)
			{
				return 0;
			}

			// Token: 0x0400A14E RID: 41294
			[Token(Token = "0x400A14E")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIWeaponSkinLobbyMainController.<>c <>9;

			// Token: 0x0400A14F RID: 41295
			[Token(Token = "0x400A14F")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<CollectionDataManager.ECollectionWeaponType> <>9__74_0;

			// Token: 0x0400A150 RID: 41296
			[Token(Token = "0x400A150")]
			[FieldOffset(Offset = "0x10")]
			public static Comparison<CollectionDataManager.ECollectionWeaponType> <>9__75_0;

			// Token: 0x0400A151 RID: 41297
			[Token(Token = "0x400A151")]
			[FieldOffset(Offset = "0x18")]
			public static Comparison<CollectionDataManager.ECollectionWeaponType> <>9__76_0;
		}
	}
}
