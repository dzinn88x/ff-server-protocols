using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001602 RID: 5634
	[Token(Token = "0x2001602")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EF8BC", Offset = "0x10EF8BC")]
	public class UIMapContentController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x06006485 RID: 25733 RVA: 0x0001CDD0 File Offset: 0x0001AFD0
		[Token(Token = "0x6006485")]
		[Address(RVA = "0x18EC5C8", Offset = "0x18EC5C8", VA = "0x7BBC0EC5C8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006486 RID: 25734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006486")]
		[Address(RVA = "0x18EC618", Offset = "0x18EC618", VA = "0x7BBC0EC618", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006487 RID: 25735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006487")]
		[Address(RVA = "0x18EEE54", Offset = "0x18EEE54", VA = "0x7BBC0EEE54", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006488 RID: 25736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006488")]
		[Address(RVA = "0x18F01A4", Offset = "0x18F01A4", VA = "0x7BBC0F01A4")]
		private void InitSpritesForSpecialMode()
		{
		}

		// Token: 0x06006489 RID: 25737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006489")]
		[Address(RVA = "0x18F0668", Offset = "0x18F0668", VA = "0x7BBC0F0668")]
		public UIWidget GetMapBgWidget()
		{
			return null;
		}

		// Token: 0x0600648A RID: 25738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600648A")]
		[Address(RVA = "0x18EC838", Offset = "0x18EC838", VA = "0x7BBC0EC838")]
		private void InitMapTexture()
		{
		}

		// Token: 0x0600648B RID: 25739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600648B")]
		[Address(RVA = "0x18ECB04", Offset = "0x18ECB04", VA = "0x7BBC0ECB04")]
		protected void RegisterEvents()
		{
		}

		// Token: 0x0600648C RID: 25740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600648C")]
		[Address(RVA = "0x18EEFF0", Offset = "0x18EEFF0", VA = "0x7BBC0EEFF0")]
		protected void UnRegisterEvents()
		{
		}

		// Token: 0x0600648D RID: 25741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600648D")]
		[Address(RVA = "0x18EDD30", Offset = "0x18EDD30", VA = "0x7BBC0EDD30")]
		private void InitUIParams()
		{
		}

		// Token: 0x0600648E RID: 25742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600648E")]
		[Address(RVA = "0x18EDE9C", Offset = "0x18EDE9C", VA = "0x7BBC0EDE9C")]
		private void InitUIElements()
		{
		}

		// Token: 0x0600648F RID: 25743 RVA: 0x0001CDE8 File Offset: 0x0001AFE8
		[Token(Token = "0x600648F")]
		[Address(RVA = "0x18F05B0", Offset = "0x18F05B0", VA = "0x7BBC0F05B0")]
		private bool ShowAllGameZone()
		{
			return default(bool);
		}

		// Token: 0x06006490 RID: 25744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006490")]
		[Address(RVA = "0x18EBE70", Offset = "0x18EBE70", VA = "0x7BBC0EBE70")]
		public void RefreshUIGroup()
		{
		}

		// Token: 0x06006491 RID: 25745 RVA: 0x0001CE00 File Offset: 0x0001B000
		[Token(Token = "0x6006491")]
		[Address(RVA = "0x18F0B8C", Offset = "0x18F0B8C", VA = "0x7BBC0F0B8C")]
		public bool ModeRelatedMinimapScale()
		{
			return default(bool);
		}

		// Token: 0x06006492 RID: 25746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006492")]
		[Address(RVA = "0x18F0DAC", Offset = "0x18F0DAC", VA = "0x7BBC0F0DAC")]
		public void SetMinimapSpriteScale(float scale, bool canDynamicScale)
		{
		}

		// Token: 0x06006493 RID: 25747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006493")]
		[Address(RVA = "0x18F12B0", Offset = "0x18F12B0", VA = "0x7BBC0F12B0")]
		public void InitBountyScanner([Optional] UIPanel panel)
		{
		}

		// Token: 0x06006494 RID: 25748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006494")]
		[Address(RVA = "0x18F1504", Offset = "0x18F1504", VA = "0x7BBC0F1504")]
		public void UpdateLocalMark(Vector3 p)
		{
		}

		// Token: 0x06006495 RID: 25749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006495")]
		[Address(RVA = "0x18F21C0", Offset = "0x18F21C0", VA = "0x7BBC0F21C0")]
		public void RemoveMarkOnMap()
		{
		}

		// Token: 0x06006496 RID: 25750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006496")]
		[Address(RVA = "0x18F247C", Offset = "0x18F247C", VA = "0x7BBC0F247C")]
		public void OnPlayerHPChangedBigMap(params object[] data)
		{
		}

		// Token: 0x06006497 RID: 25751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006497")]
		[Address(RVA = "0x18F2828", Offset = "0x18F2828", VA = "0x7BBC0F2828")]
		private void OnPlayerDead(params object[] data)
		{
		}

		// Token: 0x06006498 RID: 25752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006498")]
		[Address(RVA = "0x18F349C", Offset = "0x18F349C", VA = "0x7BBC0F349C")]
		public void OnPlayerQuit(params object[] data)
		{
		}

		// Token: 0x06006499 RID: 25753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006499")]
		[Address(RVA = "0x18F370C", Offset = "0x18F370C", VA = "0x7BBC0F370C")]
		private void OnInfoBoxDataNtf(params object[] data)
		{
		}

		// Token: 0x0600649A RID: 25754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600649A")]
		[Address(RVA = "0x18F38CC", Offset = "0x18F38CC", VA = "0x7BBC0F38CC")]
		private void OnInfoBoxValid(params object[] data)
		{
		}

		// Token: 0x0600649B RID: 25755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600649B")]
		[Address(RVA = "0x18F3C14", Offset = "0x18F3C14", VA = "0x7BBC0F3C14")]
		public void SyncTeamateState(params object[] data)
		{
		}

		// Token: 0x0600649C RID: 25756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600649C")]
		[Address(RVA = "0x18F473C", Offset = "0x18F473C", VA = "0x7BBC0F473C")]
		public void OnLocalPlayerLastVehicleChange(params object[] param)
		{
		}

		// Token: 0x0600649D RID: 25757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600649D")]
		[Address(RVA = "0x18F4864", Offset = "0x18F4864", VA = "0x7BBC0F4864")]
		private void Update()
		{
		}

		// Token: 0x0600649E RID: 25758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600649E")]
		[Address(RVA = "0x18F5F80", Offset = "0x18F5F80", VA = "0x7BBC0F5F80")]
		private void UpdateTeamatePosition()
		{
		}

		// Token: 0x0600649F RID: 25759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600649F")]
		[Address(RVA = "0x18F6E7C", Offset = "0x18F6E7C", VA = "0x7BBC0F6E7C")]
		private void UpdateEnermyPointPosition()
		{
		}

		// Token: 0x060064A0 RID: 25760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064A0")]
		[Address(RVA = "0x18F7404", Offset = "0x18F7404", VA = "0x7BBC0F7404")]
		private void UpdateDeliverySkillEnemyPointPosition()
		{
		}

		// Token: 0x060064A1 RID: 25761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064A1")]
		[Address(RVA = "0x18F7920", Offset = "0x18F7920", VA = "0x7BBC0F7920")]
		private void UpdateMaxHypePlayerPos()
		{
		}

		// Token: 0x060064A2 RID: 25762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064A2")]
		[Address(RVA = "0x18F7D60", Offset = "0x18F7D60", VA = "0x7BBC0F7D60")]
		private void UpdateRevengeMarkPos()
		{
		}

		// Token: 0x060064A3 RID: 25763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064A3")]
		[Address(RVA = "0x18F5800", Offset = "0x18F5800", VA = "0x7BBC0F5800")]
		private void UpdatePlayerStatus()
		{
		}

		// Token: 0x060064A4 RID: 25764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064A4")]
		[Address(RVA = "0x18F5ED8", Offset = "0x18F5ED8", VA = "0x7BBC0F5ED8")]
		private void UpdateGuideToMark()
		{
		}

		// Token: 0x060064A5 RID: 25765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064A5")]
		[Address(RVA = "0x18F1C8C", Offset = "0x18F1C8C", VA = "0x7BBC0F1C8C")]
		private void UpdateBigMapGuideToMark()
		{
		}

		// Token: 0x060064A6 RID: 25766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064A6")]
		[Address(RVA = "0x18F9028", Offset = "0x18F9028", VA = "0x7BBC0F9028")]
		public void OnObservePlayerBigmap(object[] data)
		{
		}

		// Token: 0x060064A7 RID: 25767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064A7")]
		[Address(RVA = "0x18F94BC", Offset = "0x18F94BC", VA = "0x7BBC0F94BC")]
		public void OnObservePlayerMinimap(object[] data)
		{
		}

		// Token: 0x060064A8 RID: 25768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064A8")]
		[Address(RVA = "0x18EC46C", Offset = "0x18EC46C", VA = "0x7BBC0EC46C")]
		public void OnObserverTargetChange()
		{
		}

		// Token: 0x060064A9 RID: 25769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064A9")]
		[Address(RVA = "0x18F9EC4", Offset = "0x18F9EC4", VA = "0x7BBC0F9EC4")]
		public void UpdateMapMarkByIndex(params object[] param)
		{
		}

		// Token: 0x060064AA RID: 25770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064AA")]
		[Address(RVA = "0x18FA13C", Offset = "0x18FA13C", VA = "0x7BBC0FA13C")]
		public void RemoveMapMarkByIndex(params object[] param)
		{
		}

		// Token: 0x060064AB RID: 25771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064AB")]
		[Address(RVA = "0x18FA25C", Offset = "0x18FA25C", VA = "0x7BBC0FA25C")]
		private void OnAddDetector(params object[] data)
		{
		}

		// Token: 0x060064AC RID: 25772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064AC")]
		[Address(RVA = "0x18FA314", Offset = "0x18FA314", VA = "0x7BBC0FA314")]
		private void CreateDetector(]XMFBq\u0081 d)
		{
		}

		// Token: 0x060064AD RID: 25773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064AD")]
		[Address(RVA = "0x18FA520", Offset = "0x18FA520", VA = "0x7BBC0FA520")]
		public void BigMapCenterSafeZone()
		{
		}

		// Token: 0x060064AE RID: 25774 RVA: 0x0001CE18 File Offset: 0x0001B018
		[Token(Token = "0x60064AE")]
		[Address(RVA = "0x18FBE00", Offset = "0x18FBE00", VA = "0x7BBC0FBE00")]
		public float GetCurrentScaleRatio()
		{
			return 0f;
		}

		// Token: 0x060064AF RID: 25775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064AF")]
		[Address(RVA = "0x18F0174", Offset = "0x18F0174", VA = "0x7BBC0F0174")]
		private void DestroyDetector()
		{
		}

		// Token: 0x060064B0 RID: 25776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064B0")]
		[Address(RVA = "0x18FBE08", Offset = "0x18FBE08", VA = "0x7BBC0FBE08")]
		public void UpdateDetector(float angle)
		{
		}

		// Token: 0x060064B1 RID: 25777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064B1")]
		[Address(RVA = "0x18FBE94", Offset = "0x18FBE94", VA = "0x7BBC0FBE94", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060064B2 RID: 25778 RVA: 0x0001CE30 File Offset: 0x0001B030
		[Token(Token = "0x60064B2")]
		[Address(RVA = "0x18FBE98", Offset = "0x18FBE98", VA = "0x7BBC0FBE98", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060064B3 RID: 25779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064B3")]
		[Address(RVA = "0x18FBEA0", Offset = "0x18FBEA0", VA = "0x7BBC0FBEA0")]
		public void OnTreasureMarked(params object[] param)
		{
		}

		// Token: 0x060064B4 RID: 25780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064B4")]
		[Address(RVA = "0x18FC18C", Offset = "0x18FC18C", VA = "0x7BBC0FC18C")]
		private void OnTreasureContainerDelete(params object[] param)
		{
		}

		// Token: 0x060064B5 RID: 25781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064B5")]
		[Address(RVA = "0x18FC2F8", Offset = "0x18FC2F8", VA = "0x7BBC0FC2F8")]
		public void OnZombieSync(GEvent data)
		{
		}

		// Token: 0x060064B6 RID: 25782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064B6")]
		[Address(RVA = "0x18FC958", Offset = "0x18FC958", VA = "0x7BBC0FC958")]
		private void AddPumpkinPos(uint id, Vector3 pos)
		{
		}

		// Token: 0x060064B7 RID: 25783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064B7")]
		[Address(RVA = "0x18FCD1C", Offset = "0x18FCD1C", VA = "0x7BBC0FCD1C")]
		public void OnPumpkinPosSync(params object[] data)
		{
		}

		// Token: 0x060064B8 RID: 25784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064B8")]
		[Address(RVA = "0x18FD050", Offset = "0x18FD050", VA = "0x7BBC0FD050")]
		public void OnPumpkinPosListSync(params object[] data)
		{
		}

		// Token: 0x060064B9 RID: 25785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064B9")]
		[Address(RVA = "0x18FD1F0", Offset = "0x18FD1F0", VA = "0x7BBC0FD1F0")]
		public void OnPlayerPumpkinPosListSync(params object[] data)
		{
		}

		// Token: 0x060064BA RID: 25786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064BA")]
		[Address(RVA = "0x18FDF64", Offset = "0x18FDF64", VA = "0x7BBC0FDF64")]
		public void OnCarePackageSync(params object[] data)
		{
		}

		// Token: 0x060064BB RID: 25787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064BB")]
		[Address(RVA = "0x18FE6D0", Offset = "0x18FE6D0", VA = "0x7BBC0FE6D0")]
		public void OnSyncWereWolvesTask(params object[] data)
		{
		}

		// Token: 0x060064BC RID: 25788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064BC")]
		[Address(RVA = "0x18FE870", Offset = "0x18FE870", VA = "0x7BBC0FE870")]
		private void SyncWereWolvesEmergencyTask(Dictionary<uint, GameObject> dic, Queue<GameObject> queue, uint objID, Vector3 position, bool needDestroy)
		{
		}

		// Token: 0x060064BD RID: 25789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064BD")]
		[Address(RVA = "0x18FEE9C", Offset = "0x18FEE9C", VA = "0x7BBC0FEE9C")]
		private void SyncWereWolvesTask(Dictionary<uint, GameObject> dic, Queue<GameObject> queue, uint objID, Vector3 position, bool needDestroy)
		{
		}

		// Token: 0x060064BE RID: 25790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064BE")]
		[Address(RVA = "0x18FF4C8", Offset = "0x18FF4C8", VA = "0x7BBC0FF4C8")]
		public void OnSyncAirDrop(params object[] data)
		{
		}

		// Token: 0x060064BF RID: 25791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064BF")]
		[Address(RVA = "0x18FE0A4", Offset = "0x18FE0A4", VA = "0x7BBC0FE0A4")]
		private void SyncAirDrop(Dictionary<uint, GameObject> dic, Queue<GameObject> queue, uint objID, Vector3 position, bool needDestroy)
		{
		}

		// Token: 0x060064C0 RID: 25792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064C0")]
		[Address(RVA = "0x18FF5F0", Offset = "0x18FF5F0", VA = "0x7BBC0FF5F0")]
		public void OnCampFireSync(params object[] data)
		{
		}

		// Token: 0x060064C1 RID: 25793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064C1")]
		[Address(RVA = "0x18FFC30", Offset = "0x18FFC30", VA = "0x7BBC0FFC30")]
		public void OnAddPlayer(params object[] data)
		{
		}

		// Token: 0x060064C2 RID: 25794 RVA: 0x0001CE48 File Offset: 0x0001B048
		[Token(Token = "0x60064C2")]
		[Address(RVA = "0x18FFE28", Offset = "0x18FFE28", VA = "0x7BBC0FFE28")]
		private bool ShouldShowJKPBuff()
		{
			return default(bool);
		}

		// Token: 0x060064C3 RID: 25795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064C3")]
		[Address(RVA = "0x18FFF0C", Offset = "0x18FFF0C", VA = "0x7BBC0FFF0C")]
		private void OnSwitchObserver(params object[] param)
		{
		}

		// Token: 0x060064C4 RID: 25796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064C4")]
		[Address(RVA = "0x1900878", Offset = "0x1900878", VA = "0x7BBC100878")]
		private void OnSyncEnermyPoint(params object[] param)
		{
		}

		// Token: 0x060064C5 RID: 25797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064C5")]
		[Address(RVA = "0x19012B0", Offset = "0x19012B0", VA = "0x7BBC1012B0")]
		private void OnSyncDeliverySkillEnemyPoint(params object[] param)
		{
		}

		// Token: 0x060064C6 RID: 25798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064C6")]
		[Address(RVA = "0x18F3168", Offset = "0x18F3168", VA = "0x7BBC0F3168")]
		private void RecycleInvisibleRevengeMark({QAb\u0082~u pID)
		{
		}

		// Token: 0x060064C7 RID: 25799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064C7")]
		[Address(RVA = "0x19016E4", Offset = "0x19016E4", VA = "0x7BBC1016E4")]
		private void OnShowItemGeneratorInfo(params object[] data)
		{
		}

		// Token: 0x060064C8 RID: 25800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064C8")]
		[Address(RVA = "0x1901908", Offset = "0x1901908", VA = "0x7BBC101908")]
		private void OnUpdateGeneratedItemInfo(params object[] data)
		{
		}

		// Token: 0x060064C9 RID: 25801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064C9")]
		[Address(RVA = "0x1901D00", Offset = "0x1901D00", VA = "0x7BBC101D00")]
		private void OnUpdateRevengeInfo(params object[] data)
		{
		}

		// Token: 0x060064CA RID: 25802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064CA")]
		[Address(RVA = "0x18F2E34", Offset = "0x18F2E34", VA = "0x7BBC0F2E34")]
		private void RecycleInvisibleMaxHypePlayer({QAb\u0082~u pID)
		{
		}

		// Token: 0x060064CB RID: 25803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064CB")]
		[Address(RVA = "0x1902064", Offset = "0x1902064", VA = "0x7BBC102064")]
		private void OnMaxHypeLevelPlayerOccurs(params object[] data)
		{
		}

		// Token: 0x060064CC RID: 25804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064CC")]
		[Address(RVA = "0x190245C", Offset = "0x190245C", VA = "0x7BBC10245C")]
		public void ReleaseMapTexture()
		{
		}

		// Token: 0x060064CD RID: 25805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064CD")]
		[Address(RVA = "0x1902590", Offset = "0x1902590", VA = "0x7BBC102590")]
		private void OnTeleportDoorStateChanged(params object[] data)
		{
		}

		// Token: 0x060064CE RID: 25806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064CE")]
		[Address(RVA = "0x190308C", Offset = "0x190308C", VA = "0x7BBC10308C")]
		public void SetTeleportDoorVisible(U` type, bool v)
		{
		}

		// Token: 0x060064CF RID: 25807 RVA: 0x0001CE60 File Offset: 0x0001B060
		[Token(Token = "0x60064CF")]
		[Address(RVA = "0x1903244", Offset = "0x1903244", VA = "0x7BBC103244")]
		public bool HasMaxHypePlayer({QAb\u0082~u pId)
		{
			return default(bool);
		}

		// Token: 0x060064D0 RID: 25808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064D0")]
		[Address(RVA = "0x19032E4", Offset = "0x19032E4", VA = "0x7BBC1032E4")]
		public void ShowMaxHypePlayerShooting({QAb\u0082~u pId, float angle)
		{
		}

		// Token: 0x060064D1 RID: 25809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064D1")]
		[Address(RVA = "0x1903598", Offset = "0x1903598", VA = "0x7BBC103598")]
		public void OnShowHotzoneOnMap(params object[] param)
		{
		}

		// Token: 0x060064D2 RID: 25810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064D2")]
		[Address(RVA = "0x1903A68", Offset = "0x1903A68", VA = "0x7BBC103A68")]
		public void OnHideHotzoneOnMap(params object[] param)
		{
		}

		// Token: 0x060064D3 RID: 25811 RVA: 0x0001CE78 File Offset: 0x0001B078
		[Token(Token = "0x60064D3")]
		[Address(RVA = "0x1903B64", Offset = "0x1903B64", VA = "0x7BBC103B64")]
		public bool HasLevelHotzoneShowing()
		{
			return default(bool);
		}

		// Token: 0x060064D4 RID: 25812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064D4")]
		[Address(RVA = "0x1903BD0", Offset = "0x1903BD0", VA = "0x7BBC103BD0")]
		public void OnShowCandyHotzoneOnMap(params object[] param)
		{
		}

		// Token: 0x060064D5 RID: 25813 RVA: 0x0001CE90 File Offset: 0x0001B090
		[Token(Token = "0x60064D5")]
		[Address(RVA = "0x1903E88", Offset = "0x1903E88", VA = "0x7BBC103E88")]
		public Vector3 GetMapPanelScale()
		{
			return default(Vector3);
		}

		// Token: 0x060064D6 RID: 25814 RVA: 0x0001CEA8 File Offset: 0x0001B0A8
		[Token(Token = "0x60064D6")]
		[Address(RVA = "0x1903EC8", Offset = "0x1903EC8", VA = "0x7BBC103EC8")]
		public Vector3 GetMapPanelLocalPos()
		{
			return default(Vector3);
		}

		// Token: 0x060064D7 RID: 25815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064D7")]
		[Address(RVA = "0x1903F08", Offset = "0x1903F08", VA = "0x7BBC103F08")]
		public Transform GetMapPanelTransform()
		{
			return null;
		}

		// Token: 0x060064D8 RID: 25816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064D8")]
		[Address(RVA = "0x1903F48", Offset = "0x1903F48", VA = "0x7BBC103F48")]
		public Dictionary<{QAb\u0082~u, TeammateGameObject> GetTeammatesMap()
		{
			return null;
		}

		// Token: 0x060064D9 RID: 25817 RVA: 0x0001CEC0 File Offset: 0x0001B0C0
		[Token(Token = "0x60064D9")]
		[Address(RVA = "0x18F1B38", Offset = "0x18F1B38", VA = "0x7BBC0F1B38")]
		private float GetOrCreateMarkScale({QAb\u0082~u playerID)
		{
			return 0f;
		}

		// Token: 0x060064DA RID: 25818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064DA")]
		[Address(RVA = "0x1903F50", Offset = "0x1903F50", VA = "0x7BBC103F50")]
		private void OnTeamParachuteModeChange(params object[] param)
		{
		}

		// Token: 0x060064DB RID: 25819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064DB")]
		[Address(RVA = "0x18F82E4", Offset = "0x18F82E4", VA = "0x7BBC0F82E4")]
		private void UpdateToxicZone()
		{
		}

		// Token: 0x060064DC RID: 25820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064DC")]
		[Address(RVA = "0x19046E0", Offset = "0x19046E0", VA = "0x7BBC1046E0")]
		private void OnShowToxicZoneOnMap(params object[] param)
		{
		}

		// Token: 0x060064DD RID: 25821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064DD")]
		[Address(RVA = "0x19046EC", Offset = "0x19046EC", VA = "0x7BBC1046EC")]
		private void OnSyncPetFindMushroomMark(params object[] param)
		{
		}

		// Token: 0x060064DE RID: 25822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064DE")]
		[Address(RVA = "0x190496C", Offset = "0x190496C", VA = "0x7BBC10496C")]
		private void SetMushRoomHide()
		{
		}

		// Token: 0x060064DF RID: 25823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064DF")]
		[Address(RVA = "0x19049B0", Offset = "0x19049B0", VA = "0x7BBC1049B0")]
		private void OnSyncPetFindMushroomRemove(params object[] param)
		{
		}

		// Token: 0x060064E0 RID: 25824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064E0")]
		[Address(RVA = "0x1904CB0", Offset = "0x1904CB0", VA = "0x7BBC104CB0")]
		private void OnShowRandomCenter(params object[] param)
		{
		}

		// Token: 0x060064E1 RID: 25825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064E1")]
		[Address(RVA = "0x1904E64", Offset = "0x1904E64", VA = "0x7BBC104E64")]
		private void OnSyncCSGameZone(params object[] param)
		{
		}

		// Token: 0x060064E2 RID: 25826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064E2")]
		[Address(RVA = "0x1904F2C", Offset = "0x1904F2C", VA = "0x7BBC104F2C")]
		private void OnShowWarningZoneOnMap(params object[] param)
		{
		}

		// Token: 0x060064E3 RID: 25827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064E3")]
		[Address(RVA = "0x1905240", Offset = "0x1905240", VA = "0x7BBC105240")]
		private void OnShowRevivePointOnMap(params object[] param)
		{
		}

		// Token: 0x060064E4 RID: 25828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064E4")]
		[Address(RVA = "0x19056F0", Offset = "0x19056F0", VA = "0x7BBC1056F0")]
		private void OnShowIngameShopOnMap(params object[] param)
		{
		}

		// Token: 0x060064E5 RID: 25829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064E5")]
		[Address(RVA = "0x1905A3C", Offset = "0x1905A3C", VA = "0x7BBC105A3C")]
		private void OnRevivePointStateChanged(params object[] param)
		{
		}

		// Token: 0x060064E6 RID: 25830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064E6")]
		[Address(RVA = "0x1905BA0", Offset = "0x1905BA0", VA = "0x7BBC105BA0")]
		private void OnBombZoneChanged(params object[] param)
		{
		}

		// Token: 0x060064E7 RID: 25831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064E7")]
		[Address(RVA = "0x18F06D8", Offset = "0x18F06D8", VA = "0x7BBC0F06D8")]
		private string GetMiniMapName(uint map_id, string lang)
		{
			return null;
		}

		// Token: 0x060064E8 RID: 25832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064E8")]
		[Address(RVA = "0x1905F68", Offset = "0x1905F68", VA = "0x7BBC105F68")]
		private void OnBombPickupGet(params object[] data)
		{
		}

		// Token: 0x060064E9 RID: 25833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064E9")]
		[Address(RVA = "0x1905FB8", Offset = "0x1905FB8", VA = "0x7BBC105FB8")]
		private void OnBombPickupDrop(params object[] data)
		{
		}

		// Token: 0x060064EA RID: 25834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064EA")]
		[Address(RVA = "0x19061C4", Offset = "0x19061C4", VA = "0x7BBC1061C4")]
		private void OnBombRoundChange(params object[] data)
		{
		}

		// Token: 0x060064EB RID: 25835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064EB")]
		[Address(RVA = "0x1906220", Offset = "0x1906220", VA = "0x7BBC106220")]
		private void OnBombSettled(params object[] data)
		{
		}

		// Token: 0x060064EC RID: 25836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064EC")]
		[Address(RVA = "0x1906408", Offset = "0x1906408", VA = "0x7BBC106408")]
		private void OnPlayerODFactionChanged(params object[] data)
		{
		}

		// Token: 0x060064ED RID: 25837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064ED")]
		[Address(RVA = "0x1906544", Offset = "0x1906544", VA = "0x7BBC106544")]
		private void OnZeppelinPosUpdate(params object[] data)
		{
		}

		// Token: 0x060064EE RID: 25838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064EE")]
		[Address(RVA = "0x19066F8", Offset = "0x19066F8", VA = "0x7BBC1066F8")]
		private void OnEscortVehiclePosUpdate(params object[] data)
		{
		}

		// Token: 0x060064EF RID: 25839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064EF")]
		[Address(RVA = "0x1906898", Offset = "0x1906898", VA = "0x7BBC106898")]
		private void OnZeppelinSpawnNextPosition(params object[] data)
		{
		}

		// Token: 0x060064F0 RID: 25840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064F0")]
		[Address(RVA = "0x18F87DC", Offset = "0x18F87DC", VA = "0x7BBC0F87DC")]
		private void UpdateZepplineMoveDirection()
		{
		}

		// Token: 0x060064F1 RID: 25841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064F1")]
		[Address(RVA = "0x1906A84", Offset = "0x1906A84", VA = "0x7BBC106A84")]
		private void OnShowBountyContract(params object[] data)
		{
		}

		// Token: 0x060064F2 RID: 25842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064F2")]
		[Address(RVA = "0x1906C5C", Offset = "0x1906C5C", VA = "0x7BBC106C5C")]
		private void OnUavCreate(params object[] data)
		{
		}

		// Token: 0x060064F3 RID: 25843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064F3")]
		[Address(RVA = "0x1906EF4", Offset = "0x1906EF4", VA = "0x7BBC106EF4")]
		private void OnUavDestroy(params object[] data)
		{
		}

		// Token: 0x060064F4 RID: 25844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064F4")]
		[Address(RVA = "0x18F8AE4", Offset = "0x18F8AE4", VA = "0x7BBC0F8AE4")]
		public void UpdateMinimapGuideToMark()
		{
		}

		// Token: 0x060064F5 RID: 25845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064F5")]
		[Address(RVA = "0x19070B8", Offset = "0x19070B8", VA = "0x7BBC1070B8")]
		public void OnPlayerHPChangedMinimap({QAb\u0082~u pId)
		{
		}

		// Token: 0x060064F6 RID: 25846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064F6")]
		[Address(RVA = "0x1907434", Offset = "0x1907434", VA = "0x7BBC107434")]
		public void EnableBigMap(EBigMapType bigMapType = EBigMapType.MapTpyeNormal)
		{
		}

		// Token: 0x060064F7 RID: 25847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064F7")]
		[Address(RVA = "0x1907798", Offset = "0x1907798", VA = "0x7BBC107798")]
		private void UpdateTeammates()
		{
		}

		// Token: 0x060064F8 RID: 25848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064F8")]
		[Address(RVA = "0x19078D8", Offset = "0x19078D8", VA = "0x7BBC1078D8")]
		public void UpdateTeammates(float scale)
		{
		}

		// Token: 0x060064F9 RID: 25849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064F9")]
		[Address(RVA = "0x1907528", Offset = "0x1907528", VA = "0x7BBC107528")]
		private void UpdateEnerPoint()
		{
		}

		// Token: 0x060064FA RID: 25850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064FA")]
		[Address(RVA = "0x19077A0", Offset = "0x19077A0", VA = "0x7BBC1077A0")]
		private void UpdateDeliverySkillPoint()
		{
		}

		// Token: 0x060064FB RID: 25851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064FB")]
		[Address(RVA = "0x1907B68", Offset = "0x1907B68", VA = "0x7BBC107B68")]
		public void InitBigmapParams(Vector3 scale, float clipWidth, float clipHeight)
		{
		}

		// Token: 0x060064FC RID: 25852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064FC")]
		[Address(RVA = "0x1907C14", Offset = "0x1907C14", VA = "0x7BBC107C14")]
		public void InitSidemapParams(Vector3 scale, float clipWidth, float clipHeight)
		{
		}

		// Token: 0x060064FD RID: 25853 RVA: 0x0001CED8 File Offset: 0x0001B0D8
		[Token(Token = "0x60064FD")]
		[Address(RVA = "0x1907CC0", Offset = "0x1907CC0", VA = "0x7BBC107CC0")]
		public float GetBigmapCurrentScaleRatio()
		{
			return 0f;
		}

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x060064FE RID: 25854 RVA: 0x0001CEF0 File Offset: 0x0001B0F0
		[Token(Token = "0x170008FB")]
		private float m_CurMarkScaleRatio
		{
			[Token(Token = "0x60064FE")]
			[Address(RVA = "0x190468C", Offset = "0x190468C", VA = "0x7BBC10468C")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060064FF RID: 25855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064FF")]
		[Address(RVA = "0x1907CC8", Offset = "0x1907CC8", VA = "0x7BBC107CC8")]
		public void UpdateTeamMapMark(uint playerIDInt, int teamIndex, bool hasMark, short posX, short posY)
		{
		}

		// Token: 0x06006500 RID: 25856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006500")]
		[Address(RVA = "0x18FAA04", Offset = "0x18FAA04", VA = "0x7BBC0FAA04")]
		public void UpdateMapScale(Vector3 targetScale)
		{
		}

		// Token: 0x06006501 RID: 25857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006501")]
		[Address(RVA = "0x19085FC", Offset = "0x19085FC", VA = "0x7BBC1085FC")]
		public void MoveMap(Vector2 deltaPos)
		{
		}

		// Token: 0x06006502 RID: 25858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006502")]
		[Address(RVA = "0x1908B30", Offset = "0x1908B30", VA = "0x7BBC108B30")]
		private void OnDetectiveMarkEnemy(params object[] data)
		{
		}

		// Token: 0x06006503 RID: 25859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006503")]
		[Address(RVA = "0x1909554", Offset = "0x1909554", VA = "0x7BBC109554")]
		private void RefreshDetectiveEffect()
		{
		}

		// Token: 0x06006504 RID: 25860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006504")]
		[Address(RVA = "0x1909798", Offset = "0x1909798", VA = "0x7BBC109798")]
		private void OnControlPhaseChange(params object[] data)
		{
		}

		// Token: 0x06006505 RID: 25861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006505")]
		[Address(RVA = "0x1909CE8", Offset = "0x1909CE8", VA = "0x7BBC109CE8")]
		private void OnShowVoteBody(params object[] data)
		{
		}

		// Token: 0x06006506 RID: 25862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006506")]
		[Address(RVA = "0x1909EF0", Offset = "0x1909EF0", VA = "0x7BBC109EF0")]
		private void OnHideVoteBody(params object[] data)
		{
		}

		// Token: 0x06006507 RID: 25863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006507")]
		[Address(RVA = "0x1909FBC", Offset = "0x1909FBC", VA = "0x7BBC109FBC")]
		public UIMapContentController()
		{
		}

		// Token: 0x06006509 RID: 25865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006509")]
		[Address(RVA = "0x190A5E0", Offset = "0x190A5E0", VA = "0x7BBC10A5E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11404AC", Offset = "0x11404AC")]
		private void <SyncTeamateState>b__101_0()
		{
		}

		// Token: 0x0600650A RID: 25866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600650A")]
		[Address(RVA = "0x190A738", Offset = "0x190A738", VA = "0x7BBC10A738")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11404BC", Offset = "0x11404BC")]
		private void <OnObservePlayerMinimap>b__113_0()
		{
		}

		// Token: 0x0600650B RID: 25867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600650B")]
		[Address(RVA = "0x190A890", Offset = "0x190A890", VA = "0x7BBC10A890")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11404CC", Offset = "0x11404CC")]
		private void <OnShowCandyHotzoneOnMap>b__159_0()
		{
		}

		// Token: 0x0600650C RID: 25868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600650C")]
		[Address(RVA = "0x190A948", Offset = "0x190A948", VA = "0x7BBC10A948")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11404DC", Offset = "0x11404DC")]
		private void <OnPlayerHPChangedMinimap>b__192_0()
		{
		}

		// Token: 0x0600650D RID: 25869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600650D")]
		[Address(RVA = "0x190AAA0", Offset = "0x190AAA0", VA = "0x7BBC10AAA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11404EC", Offset = "0x11404EC")]
		private void <OnDetectiveMarkEnemy>b__206_0()
		{
		}

		// Token: 0x0600650E RID: 25870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600650E")]
		[Address(RVA = "0x190ABC8", Offset = "0x190ABC8", VA = "0x7BBC10ABC8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11404FC", Offset = "0x11404FC")]
		private void <RefreshDetectiveEffect>b__207_0()
		{
		}

		// Token: 0x040082F4 RID: 33524
		[Token(Token = "0x40082F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private UIMapContentView m_View;

		// Token: 0x040082F5 RID: 33525
		[Token(Token = "0x40082F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Player m_Player;

		// Token: 0x040082F6 RID: 33526
		[Token(Token = "0x40082F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 m_Center;

		// Token: 0x040082F7 RID: 33527
		[Token(Token = "0x40082F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float SIZE_MAP_PIXEL_X;

		// Token: 0x040082F8 RID: 33528
		[Token(Token = "0x40082F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float SIZE_MAP_PIXEL_Y;

		// Token: 0x040082F9 RID: 33529
		[Token(Token = "0x40082F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float ZONE_DIAMETER;

		// Token: 0x040082FA RID: 33530
		[Token(Token = "0x40082FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float ZONE_DIAMETER_MAP;

		// Token: 0x040082FB RID: 33531
		[Token(Token = "0x40082FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float SIZE_MAP_X;

		// Token: 0x040082FC RID: 33532
		[Token(Token = "0x40082FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float SIZE_MAP_Z;

		// Token: 0x040082FD RID: 33533
		[Token(Token = "0x40082FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float OFFSET_SCALE_RATIO_X;

		// Token: 0x040082FE RID: 33534
		[Token(Token = "0x40082FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private GameObject m_LocalMapMark;

		// Token: 0x040082FF RID: 33535
		[Token(Token = "0x40082FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private UIMapMarkController m_LocalMapMarkController;

		// Token: 0x04008300 RID: 33536
		[Token(Token = "0x4008300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float MOVE_SENSITIVITY;

		// Token: 0x04008301 RID: 33537
		[Token(Token = "0x4008301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Dictionary<{QAb\u0082~u, float> m_TeammateMapMarkScale;

		// Token: 0x04008302 RID: 33538
		[Token(Token = "0x4008302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Dictionary<{QAb\u0082~u, UIMapMarkController> m_TeammateMapMarkDict;

		// Token: 0x04008303 RID: 33539
		[Token(Token = "0x4008303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Dictionary<{QAb\u0082~u, TeammateGameObject> m_TeammatesMap;

		// Token: 0x04008304 RID: 33540
		[Token(Token = "0x4008304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Dictionary<uint, GameObject> m_CampFireDict;

		// Token: 0x04008305 RID: 33541
		[Token(Token = "0x4008305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Dictionary<uint, GameObject> m_CarePackageDict;

		// Token: 0x04008306 RID: 33542
		[Token(Token = "0x4008306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Dictionary<uint, GameObject> m_AirDropDict;

		// Token: 0x04008307 RID: 33543
		[Token(Token = "0x4008307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Dictionary<uint, GameObject> m_WereWolvesTaskDict;

		// Token: 0x04008308 RID: 33544
		[Token(Token = "0x4008308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Dictionary<uint, GameObject> m_WereWolvesEmergencyTaskDict;

		// Token: 0x04008309 RID: 33545
		[Token(Token = "0x4008309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Dictionary<{QAb\u0082~u, GameObject> m_ZombieDict;

		// Token: 0x0400830A RID: 33546
		[Token(Token = "0x400830A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Dictionary<uint, GameObject> m_PumpkinDict;

		// Token: 0x0400830B RID: 33547
		[Token(Token = "0x400830B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Dictionary<{QAb\u0082~u, PlayerPumpkinInfo> m_PumpkinHighScoreDict;

		// Token: 0x0400830C RID: 33548
		[Token(Token = "0x400830C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private EBigMapType m_BigMapType;

		// Token: 0x0400830D RID: 33549
		[Token(Token = "0x400830D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Dictionary<uint, GameObject> m_HotzoneObjects;

		// Token: 0x0400830E RID: 33550
		[Token(Token = "0x400830E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Dictionary<uint, UISprite> m_RevivePointIcons;

		// Token: 0x0400830F RID: 33551
		[Token(Token = "0x400830F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Dictionary<uint, GameObject> m_TreasureMarks;

		// Token: 0x04008310 RID: 33552
		[Token(Token = "0x4008310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Dictionary<uint, UIHudBombZoneView> m_BombZones;

		// Token: 0x04008311 RID: 33553
		[Token(Token = "0x4008311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Color BOMB_ZONE_NO_BOMB;

		// Token: 0x04008312 RID: 33554
		[Token(Token = "0x4008312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Color BOMB_ZONE_HAS_BOMB;

		// Token: 0x04008313 RID: 33555
		[Token(Token = "0x4008313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Vector3 m_ZeppelinCurPos;

		// Token: 0x04008314 RID: 33556
		[Token(Token = "0x4008314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private Vector3 m_ZeppelinNextPos;

		// Token: 0x04008315 RID: 33557
		[Token(Token = "0x4008315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private bool m_UpdateZeppeline;

		// Token: 0x04008316 RID: 33558
		[Token(Token = "0x4008316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private Dictionary<{QAb\u0082~u, UIMapContentController.EnermyPointObject> m_EnermyPointDict;

		// Token: 0x04008317 RID: 33559
		[Token(Token = "0x4008317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private UIMapContentController.DeliveryEnermyPointObject m_DeliverySkillMarkEnemyPoint;

		// Token: 0x04008318 RID: 33560
		[Token(Token = "0x4008318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private Queue<GameObject> m_CampFireCache;

		// Token: 0x04008319 RID: 33561
		[Token(Token = "0x4008319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Queue<GameObject> m_CarePackageCache;

		// Token: 0x0400831A RID: 33562
		[Token(Token = "0x400831A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private Queue<GameObject> m_AirDropCache;

		// Token: 0x0400831B RID: 33563
		[Token(Token = "0x400831B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private Queue<GameObject> m_WereWolvesTaskCache;

		// Token: 0x0400831C RID: 33564
		[Token(Token = "0x400831C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private Queue<GameObject> m_WereWolvesEmergencyTaskCache;

		// Token: 0x0400831D RID: 33565
		[Token(Token = "0x400831D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private List<GameObject> m_BombCache;

		// Token: 0x0400831E RID: 33566
		[Token(Token = "0x400831E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private Queue<GameObject> m_ZombieCache;

		// Token: 0x0400831F RID: 33567
		[Token(Token = "0x400831F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private Queue<GameObject> m_EnermyPointCache;

		// Token: 0x04008320 RID: 33568
		[Token(Token = "0x4008320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private Queue<GameObject> m_PumpkinCache;

		// Token: 0x04008321 RID: 33569
		[Token(Token = "0x4008321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private Queue<PlayerPumpkinInfo> m_PumpkinHighScoreCache;

		// Token: 0x04008322 RID: 33570
		[Token(Token = "0x4008322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private List<GameObject> m_ToxicCache;

		// Token: 0x04008323 RID: 33571
		[Token(Token = "0x4008323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private bool m_ToxicZoneDirty;

		// Token: 0x04008324 RID: 33572
		[Token(Token = "0x4008324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private Dictionary<{QAb\u0082~u, MaxHypePlayerHint> m_RevengeMarkMap;

		// Token: 0x04008325 RID: 33573
		[Token(Token = "0x4008325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private Queue<GameObject> m_RevengeMarkCache;

		// Token: 0x04008326 RID: 33574
		[Token(Token = "0x4008326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private Dictionary<{QAb\u0082~u, MaxHypePlayerHint> m_MaxHypePlayerDic;

		// Token: 0x04008327 RID: 33575
		[Token(Token = "0x4008327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private Queue<GameObject> m_MaxHypePlayerCache;

		// Token: 0x04008328 RID: 33576
		[Token(Token = "0x4008328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private Queue<GameObject> m_GeneratedItemCache;

		// Token: 0x04008329 RID: 33577
		[Token(Token = "0x4008329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private Dictionary<uint, GeneratedItemHint> m_GeneratedItemDic;

		// Token: 0x0400832A RID: 33578
		[Token(Token = "0x400832A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private Dictionary<int, List<TeleportDoorHintInfo>> m_TeleportDoors;

		// Token: 0x0400832B RID: 33579
		[Token(Token = "0x400832B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private float PCMinimapNamePlateDefaultScale;

		// Token: 0x0400832C RID: 33580
		[Token(Token = "0x400832C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private List<UISprite> m_TeammateSprites;

		// Token: 0x0400832D RID: 33581
		[Token(Token = "0x400832D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private Vector3 m_InnerCenterPos;

		// Token: 0x0400832E RID: 33582
		[Token(Token = "0x400832E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22C")]
		private Vector3 m_InnerZoneScale;

		// Token: 0x0400832F RID: 33583
		[Token(Token = "0x400832F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private Queue m_QueueDeadTeammates;

		// Token: 0x04008330 RID: 33584
		[Token(Token = "0x4008330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private List<UavMapObject> m_UAVObjects;

		// Token: 0x04008331 RID: 33585
		[Token(Token = "0x4008331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private BountyScannerMapObject m_BountyScanner;

		// Token: 0x04008332 RID: 33586
		[Token(Token = "0x4008332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private DetectorMapObject m_Detector;

		// Token: 0x04008333 RID: 33587
		[Token(Token = "0x4008333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private float m_CurrentScaleRatio;

		// Token: 0x04008334 RID: 33588
		[Token(Token = "0x4008334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private UISprite[] m_MarkTextures;

		// Token: 0x04008335 RID: 33589
		[Token(Token = "0x4008335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		public UIMapUtil.EMapType MapType;

		// Token: 0x04008336 RID: 33590
		[Token(Token = "0x4008336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26C")]
		private bool m_MinimapScaleEnabled;

		// Token: 0x04008337 RID: 33591
		[Token(Token = "0x4008337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private float m_MinimapScale;

		// Token: 0x04008338 RID: 33592
		[Token(Token = "0x4008338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x274")]
		private Vector3 m_BigmapScaleMin;

		// Token: 0x04008339 RID: 33593
		[Token(Token = "0x4008339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private float m_ClipHeight;

		// Token: 0x0400833A RID: 33594
		[Token(Token = "0x400833A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x284")]
		private float m_ClipWidth;

		// Token: 0x0400833B RID: 33595
		[Token(Token = "0x400833B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private Dictionary<GameObject, bool[]> m_ObjectGroupSetting;

		// Token: 0x0400833C RID: 33596
		[Token(Token = "0x400833C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private SafeZone m_CurrentSafeZone;

		// Token: 0x0400833D RID: 33597
		[Token(Token = "0x400833D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private bool m_CurrentSafeZoneRect;

		// Token: 0x0400833E RID: 33598
		[Token(Token = "0x400833E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x299")]
		private bool m_BombPositionInited;

		// Token: 0x0400833F RID: 33599
		[Token(Token = "0x400833F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private List<UISprite> m_ReaperPlayerFlag;

		// Token: 0x04008340 RID: 33600
		[Token(Token = "0x4008340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private List<GameObject> m_DetectiveMarkPoints;

		// Token: 0x04008341 RID: 33601
		[Token(Token = "0x4008341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		private uint m_CandyHotZoneDelayCallID;

		// Token: 0x02001603 RID: 5635
		[Token(Token = "0x2001603")]
		private struct EnermyPointObject
		{
			// Token: 0x04008342 RID: 33602
			[Token(Token = "0x4008342")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public GameObject PointObject;

			// Token: 0x04008343 RID: 33603
			[Token(Token = "0x4008343")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public {QAb\u0082~u EnermyID;

			// Token: 0x04008344 RID: 33604
			[Token(Token = "0x4008344")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int ServerEndTime;
		}

		// Token: 0x02001604 RID: 5636
		[Token(Token = "0x2001604")]
		private class DeliveryEnermyPointObject
		{
			// Token: 0x0600650F RID: 25871 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600650F")]
			[Address(RVA = "0x1469514", Offset = "0x1469514", VA = "0x7BBBC69514")]
			public void Reset()
			{
			}

			// Token: 0x06006510 RID: 25872 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006510")]
			[Address(RVA = "0x1469614", Offset = "0x1469614", VA = "0x7BBBC69614")]
			public DeliveryEnermyPointObject()
			{
			}

			// Token: 0x04008345 RID: 33605
			[Token(Token = "0x4008345")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject PointObject;

			// Token: 0x04008346 RID: 33606
			[Token(Token = "0x4008346")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public {QAb\u0082~u EnermyID;

			// Token: 0x04008347 RID: 33607
			[Token(Token = "0x4008347")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int ServerEndTime;

			// Token: 0x04008348 RID: 33608
			[Token(Token = "0x4008348")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public bool Marked;
		}

		// Token: 0x02001605 RID: 5637
		[Token(Token = "0x2001605")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EF8F4", Offset = "0x10EF8F4")]
		private sealed class <>c__DisplayClass151_0
		{
			// Token: 0x06006511 RID: 25873 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006511")]
			[Address(RVA = "0x1469430", Offset = "0x1469430", VA = "0x7BBBC69430")]
			public <>c__DisplayClass151_0()
			{
			}

			// Token: 0x06006512 RID: 25874 RVA: 0x0001CF08 File Offset: 0x0001B108
			[Token(Token = "0x6006512")]
			[Address(RVA = "0x1469438", Offset = "0x1469438", VA = "0x7BBBC69438")]
			internal bool <OnTeleportDoorStateChanged>b__0(TeleportDoorHintInfo e)
			{
				return default(bool);
			}

			// Token: 0x06006513 RID: 25875 RVA: 0x0001CF20 File Offset: 0x0001B120
			[Token(Token = "0x6006513")]
			[Address(RVA = "0x1469474", Offset = "0x1469474", VA = "0x7BBBC69474")]
			internal bool <OnTeleportDoorStateChanged>b__1(TeleportDoorHintInfo e)
			{
				return default(bool);
			}

			// Token: 0x04008349 RID: 33609
			[Token(Token = "0x4008349")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public uint uid;
		}

		// Token: 0x02001606 RID: 5638
		[Token(Token = "0x2001606")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EF904", Offset = "0x10EF904")]
		private sealed class <>c__DisplayClass154_0
		{
			// Token: 0x06006514 RID: 25876 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006514")]
			[Address(RVA = "0x14694B0", Offset = "0x14694B0", VA = "0x7BBBC694B0")]
			public <>c__DisplayClass154_0()
			{
			}

			// Token: 0x06006515 RID: 25877 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006515")]
			[Address(RVA = "0x14694B8", Offset = "0x14694B8", VA = "0x7BBBC694B8")]
			internal void <ShowMaxHypePlayerShooting>b__0()
			{
			}

			// Token: 0x0400834A RID: 33610
			[Token(Token = "0x400834A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MaxHypePlayerHint hint;
		}
	}
}
