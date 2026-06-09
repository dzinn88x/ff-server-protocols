using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200176F RID: 5999
	[Token(Token = "0x200176F")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F20D4", Offset = "0x10F20D4")]
	internal class UICreateRoomController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x06007136 RID: 28982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000936")]
		protected List<UICreateRoomMapItem> MapItemList
		{
			[Token(Token = "0x6007136")]
			[Address(RVA = "0x181A890", Offset = "0x181A890", VA = "0x7BBC01A890")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007137 RID: 28983 RVA: 0x0001FA10 File Offset: 0x0001DC10
		[Token(Token = "0x6007137")]
		[Address(RVA = "0x181A904", Offset = "0x181A904", VA = "0x7BBC01A904")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007138 RID: 28984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007138")]
		[Address(RVA = "0x181A954", Offset = "0x181A954", VA = "0x7BBC01A954", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007139 RID: 28985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007139")]
		[Address(RVA = "0x181BE5C", Offset = "0x181BE5C", VA = "0x7BBC01BE5C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600713A RID: 28986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600713A")]
		[Address(RVA = "0x181C0FC", Offset = "0x181C0FC", VA = "0x7BBC01C0FC", Slot = "42")]
		protected virtual void InitPopMenus()
		{
		}

		// Token: 0x0600713B RID: 28987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600713B")]
		[Address(RVA = "0x181C2DC", Offset = "0x181C2DC", VA = "0x7BBC01C2DC", Slot = "35")]
		protected override void OnInitDepth()
		{
		}

		// Token: 0x0600713C RID: 28988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600713C")]
		[Address(RVA = "0x181B308", Offset = "0x181B308", VA = "0x7BBC01B308")]
		private void InitStandardTabs()
		{
		}

		// Token: 0x0600713D RID: 28989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600713D")]
		[Address(RVA = "0x181C498", Offset = "0x181C498", VA = "0x7BBC01C498", Slot = "43")]
		protected virtual void InitToggleBtns()
		{
		}

		// Token: 0x0600713E RID: 28990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600713E")]
		[Address(RVA = "0x181E258", Offset = "0x181E258", VA = "0x7BBC01E258", Slot = "44")]
		protected virtual void CalMapConfig()
		{
		}

		// Token: 0x0600713F RID: 28991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600713F")]
		[Address(RVA = "0x181B6C0", Offset = "0x181B6C0", VA = "0x7BBC01B6C0")]
		private void InitUIContents()
		{
		}

		// Token: 0x06007140 RID: 28992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007140")]
		[Address(RVA = "0x181EED8", Offset = "0x181EED8", VA = "0x7BBC01EED8")]
		protected void OnSoloToggleClick()
		{
		}

		// Token: 0x06007141 RID: 28993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007141")]
		[Address(RVA = "0x181F174", Offset = "0x181F174", VA = "0x7BBC01F174")]
		protected void OnDuoToggleClick()
		{
		}

		// Token: 0x06007142 RID: 28994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007142")]
		[Address(RVA = "0x181F180", Offset = "0x181F180", VA = "0x7BBC01F180")]
		protected void OnQuadToggleClick()
		{
		}

		// Token: 0x06007143 RID: 28995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007143")]
		[Address(RVA = "0x181F18C", Offset = "0x181F18C", VA = "0x7BBC01F18C")]
		protected void OnBtnLeagueNormalRoomClick()
		{
		}

		// Token: 0x06007144 RID: 28996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007144")]
		[Address(RVA = "0x181F198", Offset = "0x181F198", VA = "0x7BBC01F198")]
		protected void OnBtnCasualRoomClick()
		{
		}

		// Token: 0x06007145 RID: 28997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007145")]
		[Address(RVA = "0x181F1A4", Offset = "0x181F1A4", VA = "0x7BBC01F1A4")]
		protected void OnBtnBatchRoomClick()
		{
		}

		// Token: 0x06007146 RID: 28998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007146")]
		[Address(RVA = "0x181F1B0", Offset = "0x181F1B0", VA = "0x7BBC01F1B0")]
		private void OnRoomSettingClick()
		{
		}

		// Token: 0x06007147 RID: 28999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007147")]
		[Address(RVA = "0x181F290", Offset = "0x181F290", VA = "0x7BBC01F290")]
		private void OnGameSettingClick()
		{
		}

		// Token: 0x06007148 RID: 29000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007148")]
		[Address(RVA = "0x181F370", Offset = "0x181F370", VA = "0x7BBC01F370")]
		private void OnOBSettingClick()
		{
		}

		// Token: 0x06007149 RID: 29001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007149")]
		[Address(RVA = "0x181F450", Offset = "0x181F450", VA = "0x7BBC01F450")]
		private void OnCSAdSettingClick()
		{
		}

		// Token: 0x0600714A RID: 29002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600714A")]
		[Address(RVA = "0x181E718", Offset = "0x181E718", VA = "0x7BBC01E718")]
		private void SetFirstValidGroupMode()
		{
		}

		// Token: 0x0600714B RID: 29003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600714B")]
		[Address(RVA = "0x181EEE0", Offset = "0x181EEE0", VA = "0x7BBC01EEE0")]
		private void SetValidMenuData()
		{
		}

		// Token: 0x0600714C RID: 29004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600714C")]
		[Address(RVA = "0x181F56C", Offset = "0x181F56C", VA = "0x7BBC01F56C")]
		private void RefreshGameSettingInfo()
		{
		}

		// Token: 0x0600714D RID: 29005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600714D")]
		[Address(RVA = "0x181F92C", Offset = "0x181F92C", VA = "0x7BBC01F92C")]
		protected void RefreshGameDropInfo()
		{
		}

		// Token: 0x0600714E RID: 29006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600714E")]
		[Address(RVA = "0x181EC58", Offset = "0x181EC58", VA = "0x7BBC01EC58")]
		protected void RepositionAllSettings()
		{
		}

		// Token: 0x0600714F RID: 29007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600714F")]
		[Address(RVA = "0x181EE14", Offset = "0x181EE14", VA = "0x7BBC01EE14")]
		protected void SetGameModeSpecificUI()
		{
		}

		// Token: 0x06007150 RID: 29008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007150")]
		[Address(RVA = "0x181FCB0", Offset = "0x181FCB0", VA = "0x7BBC01FCB0")]
		private void UpdateBtnGrid()
		{
		}

		// Token: 0x06007151 RID: 29009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007151")]
		[Address(RVA = "0x18200BC", Offset = "0x18200BC", VA = "0x7BBC0200BC")]
		private List<PopMenuData> GenerateMembersMenuData()
		{
			return null;
		}

		// Token: 0x06007152 RID: 29010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007152")]
		[Address(RVA = "0x1820314", Offset = "0x1820314", VA = "0x7BBC020314")]
		private void OnMemberSelected(object obj)
		{
		}

		// Token: 0x06007153 RID: 29011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007153")]
		[Address(RVA = "0x1820534", Offset = "0x1820534", VA = "0x7BBC020534")]
		private List<PopMenuData> GenerateSpectatorsMenuData()
		{
			return null;
		}

		// Token: 0x06007154 RID: 29012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007154")]
		[Address(RVA = "0x182078C", Offset = "0x182078C", VA = "0x7BBC02078C")]
		private void OnSpectatorSelected(object obj)
		{
		}

		// Token: 0x06007155 RID: 29013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007155")]
		[Address(RVA = "0x18209AC", Offset = "0x18209AC", VA = "0x7BBC0209AC")]
		private List<PopMenuData> GenerateHPMenuData()
		{
			return null;
		}

		// Token: 0x06007156 RID: 29014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007156")]
		[Address(RVA = "0x1820C28", Offset = "0x1820C28", VA = "0x7BBC020C28")]
		private void OnHPSelected(object obj)
		{
		}

		// Token: 0x06007157 RID: 29015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007157")]
		[Address(RVA = "0x1820CF4", Offset = "0x1820CF4", VA = "0x7BBC020CF4")]
		private List<PopMenuData> GenerateEPMenuData()
		{
			return null;
		}

		// Token: 0x06007158 RID: 29016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007158")]
		[Address(RVA = "0x1820F70", Offset = "0x1820F70", VA = "0x7BBC020F70")]
		private void OnEPSelected(object obj)
		{
		}

		// Token: 0x06007159 RID: 29017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007159")]
		[Address(RVA = "0x182103C", Offset = "0x182103C", VA = "0x7BBC02103C")]
		private List<PopMenuData> GenerateSpeedMenuData()
		{
			return null;
		}

		// Token: 0x0600715A RID: 29018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600715A")]
		[Address(RVA = "0x18212B8", Offset = "0x18212B8", VA = "0x7BBC0212B8")]
		private void OnSpeedSelected(object obj)
		{
		}

		// Token: 0x0600715B RID: 29019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600715B")]
		[Address(RVA = "0x1821384", Offset = "0x1821384", VA = "0x7BBC021384")]
		private List<PopMenuData> GenerateJumpHeightMenuData()
		{
			return null;
		}

		// Token: 0x0600715C RID: 29020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600715C")]
		[Address(RVA = "0x1821600", Offset = "0x1821600", VA = "0x7BBC021600")]
		private void OnJumpHeightSelected(object obj)
		{
		}

		// Token: 0x0600715D RID: 29021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600715D")]
		[Address(RVA = "0x181FE84", Offset = "0x181FE84", VA = "0x7BBC01FE84")]
		public void RefreshADCSRelatedInfo(params object[] data)
		{
		}

		// Token: 0x0600715E RID: 29022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600715E")]
		[Address(RVA = "0x18216CC", Offset = "0x18216CC", VA = "0x7BBC0216CC")]
		private List<PopMenuData> GenerateRoundNumMenuData()
		{
			return null;
		}

		// Token: 0x0600715F RID: 29023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600715F")]
		[Address(RVA = "0x1821948", Offset = "0x1821948", VA = "0x7BBC021948")]
		private void OnRoundNumSelected(object obj)
		{
		}

		// Token: 0x06007160 RID: 29024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007160")]
		[Address(RVA = "0x1821A24", Offset = "0x1821A24", VA = "0x7BBC021A24")]
		private List<PopMenuData> GenerateInitCoinMenuData()
		{
			return null;
		}

		// Token: 0x06007161 RID: 29025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007161")]
		[Address(RVA = "0x1821CA0", Offset = "0x1821CA0", VA = "0x7BBC021CA0")]
		private void OnInitCoinSelected(object obj)
		{
		}

		// Token: 0x06007162 RID: 29026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007162")]
		[Address(RVA = "0x1821D7C", Offset = "0x1821D7C", VA = "0x7BBC021D7C")]
		protected void GenerateGameModeMenuData()
		{
		}

		// Token: 0x06007163 RID: 29027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007163")]
		[Address(RVA = "0x1822028", Offset = "0x1822028", VA = "0x7BBC022028")]
		protected void OnModeSelected(object obj)
		{
		}

		// Token: 0x06007164 RID: 29028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007164")]
		[Address(RVA = "0x181E2A4", Offset = "0x181E2A4", VA = "0x7BBC01E2A4")]
		protected void RefreshMapGridView()
		{
		}

		// Token: 0x06007165 RID: 29029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007165")]
		[Address(RVA = "0x18225E4", Offset = "0x18225E4", VA = "0x7BBC0225E4")]
		private void OnMapDownloadClick(uint configID, string mapName)
		{
		}

		// Token: 0x06007166 RID: 29030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007166")]
		[Address(RVA = "0x1822914", Offset = "0x1822914", VA = "0x7BBC022914")]
		private void OnMapToggleSelect(uint configID)
		{
		}

		// Token: 0x06007167 RID: 29031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007167")]
		[Address(RVA = "0x182291C", Offset = "0x182291C", VA = "0x7BBC02291C")]
		private void ProcessWeatherOnMapSelected()
		{
		}

		// Token: 0x06007168 RID: 29032 RVA: 0x0001FA28 File Offset: 0x0001DC28
		[Token(Token = "0x6007168")]
		[Address(RVA = "0x1822430", Offset = "0x1822430", VA = "0x7BBC022430")]
		protected uint SetFirstValidMapByMode(uint modeId)
		{
			return 0U;
		}

		// Token: 0x06007169 RID: 29033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007169")]
		[Address(RVA = "0x1822AD8", Offset = "0x1822AD8", VA = "0x7BBC022AD8")]
		protected void GenerateDropModeMenuData()
		{
		}

		// Token: 0x0600716A RID: 29034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600716A")]
		[Address(RVA = "0x1822D9C", Offset = "0x1822D9C", VA = "0x7BBC022D9C")]
		protected void OnDropSelected(object obj)
		{
		}

		// Token: 0x0600716B RID: 29035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600716B")]
		[Address(RVA = "0x181FAE4", Offset = "0x181FAE4", VA = "0x7BBC01FAE4")]
		protected void InitOtherSettingsByDrop(DropListConfigInfo info)
		{
		}

		// Token: 0x0600716C RID: 29036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600716C")]
		[Address(RVA = "0x1822E6C", Offset = "0x1822E6C", VA = "0x7BBC022E6C")]
		protected void OnBtnConfirm()
		{
		}

		// Token: 0x0600716D RID: 29037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600716D")]
		[Address(RVA = "0x1823A9C", Offset = "0x1823A9C", VA = "0x7BBC023A9C")]
		private void ShowNormalConfirmPop()
		{
		}

		// Token: 0x0600716E RID: 29038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600716E")]
		[Address(RVA = "0x1823E24", Offset = "0x1823E24", VA = "0x7BBC023E24")]
		private void CloseUI(params object[] data)
		{
		}

		// Token: 0x0600716F RID: 29039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600716F")]
		[Address(RVA = "0x1823E2C", Offset = "0x1823E2C", VA = "0x7BBC023E2C")]
		private void OnBtnClose()
		{
		}

		// Token: 0x06007170 RID: 29040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007170")]
		[Address(RVA = "0x1823E34", Offset = "0x1823E34", VA = "0x7BBC023E34")]
		private void OnBtnReset()
		{
		}

		// Token: 0x06007171 RID: 29041 RVA: 0x0001FA40 File Offset: 0x0001DC40
		[Token(Token = "0x6007171")]
		[Address(RVA = "0x181E204", Offset = "0x181E204", VA = "0x7BBC01E204")]
		private bool IsRoomSettingsTrue(ECustomRoomSetting setting)
		{
			return default(bool);
		}

		// Token: 0x06007172 RID: 29042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007172")]
		[Address(RVA = "0x181E21C", Offset = "0x181E21C", VA = "0x7BBC01E21C")]
		private void SetRoomSetting(ECustomRoomSetting setting, bool value)
		{
		}

		// Token: 0x06007173 RID: 29043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007173")]
		[Address(RVA = "0x1823F88", Offset = "0x1823F88", VA = "0x7BBC023F88")]
		private void SetRoomSetting(uint setting, bool value)
		{
		}

		// Token: 0x06007174 RID: 29044 RVA: 0x0001FA58 File Offset: 0x0001DC58
		[Token(Token = "0x6007174")]
		[Address(RVA = "0x181E210", Offset = "0x181E210", VA = "0x7BBC01E210")]
		private bool IsRoomSettings2True(ECustomRoomSetting2 setting)
		{
			return default(bool);
		}

		// Token: 0x06007175 RID: 29045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007175")]
		[Address(RVA = "0x1823FC4", Offset = "0x1823FC4", VA = "0x7BBC023FC4")]
		private void SetRoomSetting2(ECustomRoomSetting2 setting, bool value)
		{
		}

		// Token: 0x06007176 RID: 29046 RVA: 0x0001FA70 File Offset: 0x0001DC70
		[Token(Token = "0x6007176")]
		[Address(RVA = "0x1824000", Offset = "0x1824000", VA = "0x7BBC024000")]
		private bool IsRoomSettingsTrue(uint setting)
		{
			return default(bool);
		}

		// Token: 0x06007177 RID: 29047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007177")]
		[Address(RVA = "0x181FA8C", Offset = "0x181FA8C", VA = "0x7BBC01FA8C")]
		protected void SetRoomSettingValue(ECustomRoomSetting start, ECustomRoomSetting end, uint value)
		{
		}

		// Token: 0x06007178 RID: 29048 RVA: 0x0001FA88 File Offset: 0x0001DC88
		[Token(Token = "0x6007178")]
		[Address(RVA = "0x182400C", Offset = "0x182400C", VA = "0x7BBC02400C")]
		protected uint GetRoomSettingValue(ECustomRoomSetting start, ECustomRoomSetting end)
		{
			return 0U;
		}

		// Token: 0x06007179 RID: 29049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007179")]
		[Address(RVA = "0x1824070", Offset = "0x1824070", VA = "0x7BBC024070", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600717A RID: 29050 RVA: 0x0001FAA0 File Offset: 0x0001DCA0
		[Token(Token = "0x600717A")]
		[Address(RVA = "0x18240E8", Offset = "0x18240E8", VA = "0x7BBC0240E8", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600717B RID: 29051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600717B")]
		[Address(RVA = "0x182412C", Offset = "0x182412C", VA = "0x7BBC02412C")]
		public UICreateRoomController()
		{
		}

		// Token: 0x0600717C RID: 29052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600717C")]
		[Address(RVA = "0x18241B8", Offset = "0x18241B8", VA = "0x7BBC0241B8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11415FC", Offset = "0x11415FC")]
		private void <InitToggleBtns>b__64_0()
		{
		}

		// Token: 0x0600717D RID: 29053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600717D")]
		[Address(RVA = "0x18241C4", Offset = "0x18241C4", VA = "0x7BBC0241C4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114160C", Offset = "0x114160C")]
		private void <InitToggleBtns>b__64_1()
		{
		}

		// Token: 0x0600717E RID: 29054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600717E")]
		[Address(RVA = "0x18241CC", Offset = "0x18241CC", VA = "0x7BBC0241CC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114161C", Offset = "0x114161C")]
		private void <InitToggleBtns>b__64_2()
		{
		}

		// Token: 0x0600717F RID: 29055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600717F")]
		[Address(RVA = "0x18241D4", Offset = "0x18241D4", VA = "0x7BBC0241D4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114162C", Offset = "0x114162C")]
		private void <InitToggleBtns>b__64_3()
		{
		}

		// Token: 0x06007180 RID: 29056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007180")]
		[Address(RVA = "0x18241E0", Offset = "0x18241E0", VA = "0x7BBC0241E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114163C", Offset = "0x114163C")]
		private void <InitToggleBtns>b__64_4()
		{
		}

		// Token: 0x06007181 RID: 29057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007181")]
		[Address(RVA = "0x1824210", Offset = "0x1824210", VA = "0x7BBC024210")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114164C", Offset = "0x114164C")]
		private void <InitToggleBtns>b__64_5()
		{
		}

		// Token: 0x06007182 RID: 29058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007182")]
		[Address(RVA = "0x1824240", Offset = "0x1824240", VA = "0x7BBC024240")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114165C", Offset = "0x114165C")]
		private void <InitToggleBtns>b__64_6()
		{
		}

		// Token: 0x06007183 RID: 29059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007183")]
		[Address(RVA = "0x1824270", Offset = "0x1824270", VA = "0x7BBC024270")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114166C", Offset = "0x114166C")]
		private void <InitToggleBtns>b__64_7()
		{
		}

		// Token: 0x06007184 RID: 29060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007184")]
		[Address(RVA = "0x18242A0", Offset = "0x18242A0", VA = "0x7BBC0242A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114167C", Offset = "0x114167C")]
		private void <InitToggleBtns>b__64_8()
		{
		}

		// Token: 0x06007185 RID: 29061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007185")]
		[Address(RVA = "0x18242D0", Offset = "0x18242D0", VA = "0x7BBC0242D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114168C", Offset = "0x114168C")]
		private void <InitToggleBtns>b__64_9()
		{
		}

		// Token: 0x06007186 RID: 29062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007186")]
		[Address(RVA = "0x1824300", Offset = "0x1824300", VA = "0x7BBC024300")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114169C", Offset = "0x114169C")]
		private void <InitToggleBtns>b__64_10()
		{
		}

		// Token: 0x06007187 RID: 29063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007187")]
		[Address(RVA = "0x1824330", Offset = "0x1824330", VA = "0x7BBC024330")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11416AC", Offset = "0x11416AC")]
		private void <InitToggleBtns>b__64_11()
		{
		}

		// Token: 0x06007188 RID: 29064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007188")]
		[Address(RVA = "0x1824360", Offset = "0x1824360", VA = "0x7BBC024360")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11416BC", Offset = "0x11416BC")]
		private void <InitToggleBtns>b__64_12()
		{
		}

		// Token: 0x06007189 RID: 29065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007189")]
		[Address(RVA = "0x1824390", Offset = "0x1824390", VA = "0x7BBC024390")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11416CC", Offset = "0x11416CC")]
		private void <InitToggleBtns>b__64_13()
		{
		}

		// Token: 0x0600718A RID: 29066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600718A")]
		[Address(RVA = "0x18243C0", Offset = "0x18243C0", VA = "0x7BBC0243C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11416DC", Offset = "0x11416DC")]
		private void <InitToggleBtns>b__64_14()
		{
		}

		// Token: 0x0600718B RID: 29067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600718B")]
		[Address(RVA = "0x18243F0", Offset = "0x18243F0", VA = "0x7BBC0243F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11416EC", Offset = "0x11416EC")]
		private void <InitToggleBtns>b__64_15()
		{
		}

		// Token: 0x0600718C RID: 29068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600718C")]
		[Address(RVA = "0x1824420", Offset = "0x1824420", VA = "0x7BBC024420")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11416FC", Offset = "0x11416FC")]
		private void <InitToggleBtns>b__64_16()
		{
		}

		// Token: 0x0600718D RID: 29069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600718D")]
		[Address(RVA = "0x1824450", Offset = "0x1824450", VA = "0x7BBC024450")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114170C", Offset = "0x114170C")]
		private void <InitToggleBtns>b__64_17()
		{
		}

		// Token: 0x0600718E RID: 29070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600718E")]
		[Address(RVA = "0x1824480", Offset = "0x1824480", VA = "0x7BBC024480")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114171C", Offset = "0x114171C")]
		private void <InitToggleBtns>b__64_18()
		{
		}

		// Token: 0x0600718F RID: 29071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600718F")]
		[Address(RVA = "0x18244B0", Offset = "0x18244B0", VA = "0x7BBC0244B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114172C", Offset = "0x114172C")]
		private void <InitToggleBtns>b__64_19()
		{
		}

		// Token: 0x06007190 RID: 29072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007190")]
		[Address(RVA = "0x18244E0", Offset = "0x18244E0", VA = "0x7BBC0244E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114173C", Offset = "0x114173C")]
		private void <InitToggleBtns>b__64_20()
		{
		}

		// Token: 0x06007191 RID: 29073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007191")]
		[Address(RVA = "0x1824510", Offset = "0x1824510", VA = "0x7BBC024510")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114174C", Offset = "0x114174C")]
		private void <InitToggleBtns>b__64_21()
		{
		}

		// Token: 0x06007192 RID: 29074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007192")]
		[Address(RVA = "0x1824540", Offset = "0x1824540", VA = "0x7BBC024540")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114175C", Offset = "0x114175C")]
		private void <InitToggleBtns>b__64_22()
		{
		}

		// Token: 0x06007193 RID: 29075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007193")]
		[Address(RVA = "0x1824570", Offset = "0x1824570", VA = "0x7BBC024570")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114176C", Offset = "0x114176C")]
		private void <InitToggleBtns>b__64_23()
		{
		}

		// Token: 0x06007194 RID: 29076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007194")]
		[Address(RVA = "0x18245A0", Offset = "0x18245A0", VA = "0x7BBC0245A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114177C", Offset = "0x114177C")]
		private void <InitToggleBtns>b__64_24()
		{
		}

		// Token: 0x06007195 RID: 29077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007195")]
		[Address(RVA = "0x18245D0", Offset = "0x18245D0", VA = "0x7BBC0245D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114178C", Offset = "0x114178C")]
		private void <InitToggleBtns>b__64_25()
		{
		}

		// Token: 0x06007196 RID: 29078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007196")]
		[Address(RVA = "0x1824600", Offset = "0x1824600", VA = "0x7BBC024600")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114179C", Offset = "0x114179C")]
		private void <InitToggleBtns>b__64_26()
		{
		}

		// Token: 0x06007197 RID: 29079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007197")]
		[Address(RVA = "0x1824630", Offset = "0x1824630", VA = "0x7BBC024630")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11417AC", Offset = "0x11417AC")]
		private void <InitToggleBtns>b__64_27()
		{
		}

		// Token: 0x06007198 RID: 29080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007198")]
		[Address(RVA = "0x1824660", Offset = "0x1824660", VA = "0x7BBC024660")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11417BC", Offset = "0x11417BC")]
		private void <InitToggleBtns>b__64_28()
		{
		}

		// Token: 0x06007199 RID: 29081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007199")]
		[Address(RVA = "0x1824690", Offset = "0x1824690", VA = "0x7BBC024690")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11417CC", Offset = "0x11417CC")]
		private void <InitToggleBtns>b__64_29()
		{
		}

		// Token: 0x0600719A RID: 29082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600719A")]
		[Address(RVA = "0x18246C0", Offset = "0x18246C0", VA = "0x7BBC0246C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11417DC", Offset = "0x11417DC")]
		private void <InitToggleBtns>b__64_30()
		{
		}

		// Token: 0x0600719B RID: 29083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600719B")]
		[Address(RVA = "0x18246F0", Offset = "0x18246F0", VA = "0x7BBC0246F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11417EC", Offset = "0x11417EC")]
		private void <InitToggleBtns>b__64_31()
		{
		}

		// Token: 0x0600719C RID: 29084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600719C")]
		[Address(RVA = "0x1824720", Offset = "0x1824720", VA = "0x7BBC024720")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11417FC", Offset = "0x11417FC")]
		private void <InitToggleBtns>b__64_32()
		{
		}

		// Token: 0x0600719D RID: 29085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600719D")]
		[Address(RVA = "0x182472C", Offset = "0x182472C", VA = "0x7BBC02472C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114180C", Offset = "0x114180C")]
		private void <InitToggleBtns>b__64_33()
		{
		}

		// Token: 0x0600719E RID: 29086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600719E")]
		[Address(RVA = "0x1824734", Offset = "0x1824734", VA = "0x7BBC024734")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114181C", Offset = "0x114181C")]
		private void <InitToggleBtns>b__64_34()
		{
		}

		// Token: 0x0600719F RID: 29087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600719F")]
		[Address(RVA = "0x1824740", Offset = "0x1824740", VA = "0x7BBC024740")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114182C", Offset = "0x114182C")]
		private void <InitToggleBtns>b__64_35()
		{
		}

		// Token: 0x060071A0 RID: 29088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071A0")]
		[Address(RVA = "0x1824748", Offset = "0x1824748", VA = "0x7BBC024748")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114183C", Offset = "0x114183C")]
		private void <OnBtnConfirm>b__111_0()
		{
		}

		// Token: 0x060071A1 RID: 29089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071A1")]
		[Address(RVA = "0x182474C", Offset = "0x182474C", VA = "0x7BBC02474C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114184C", Offset = "0x114184C")]
		private void <ShowNormalConfirmPop>b__112_0()
		{
		}

		// Token: 0x060071A2 RID: 29090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071A2")]
		[Address(RVA = "0x1824B90", Offset = "0x1824B90", VA = "0x7BBC024B90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114185C", Offset = "0x114185C")]
		private void <OnBtnReset>b__115_0()
		{
		}

		// Token: 0x04008ACD RID: 35533
		[Token(Token = "0x4008ACD")]
		[FieldOffset(Offset = "0x98")]
		protected UICreateRoomView m_View;

		// Token: 0x04008ACE RID: 35534
		[Token(Token = "0x4008ACE")]
		[FieldOffset(Offset = "0xA0")]
		protected RoomCreateRuleDataManager m_DataManager;

		// Token: 0x04008ACF RID: 35535
		[Token(Token = "0x4008ACF")]
		[FieldOffset(Offset = "0xA8")]
		protected UIModelCustomRoom m_CustomRoomModel;

		// Token: 0x04008AD0 RID: 35536
		[Token(Token = "0x4008AD0")]
		[FieldOffset(Offset = "0xB0")]
		protected List<PopMenuData> m_DataList;

		// Token: 0x04008AD1 RID: 35537
		[Token(Token = "0x4008AD1")]
		[FieldOffset(Offset = "0xB8")]
		protected uint m_MapConfigId;

		// Token: 0x04008AD2 RID: 35538
		[Token(Token = "0x4008AD2")]
		[FieldOffset(Offset = "0xC0")]
		protected string m_Name;

		// Token: 0x04008AD3 RID: 35539
		[Token(Token = "0x4008AD3")]
		[FieldOffset(Offset = "0xC8")]
		protected string m_Code;

		// Token: 0x04008AD4 RID: 35540
		[Token(Token = "0x4008AD4")]
		[FieldOffset(Offset = "0xD0")]
		protected uint m_GroupMode;

		// Token: 0x04008AD5 RID: 35541
		[Token(Token = "0x4008AD5")]
		[FieldOffset(Offset = "0xD4")]
		protected uint m_MemberNum;

		// Token: 0x04008AD6 RID: 35542
		[Token(Token = "0x4008AD6")]
		[FieldOffset(Offset = "0xD8")]
		protected uint m_SpectatorNum;

		// Token: 0x04008AD7 RID: 35543
		[Token(Token = "0x4008AD7")]
		[FieldOffset(Offset = "0xE0")]
		protected string m_Hp;

		// Token: 0x04008AD8 RID: 35544
		[Token(Token = "0x4008AD8")]
		[FieldOffset(Offset = "0xE8")]
		protected string m_Ep;

		// Token: 0x04008AD9 RID: 35545
		[Token(Token = "0x4008AD9")]
		[FieldOffset(Offset = "0xF0")]
		protected string m_Speed;

		// Token: 0x04008ADA RID: 35546
		[Token(Token = "0x4008ADA")]
		[FieldOffset(Offset = "0xF8")]
		protected string m_JumpHeght;

		// Token: 0x04008ADB RID: 35547
		[Token(Token = "0x4008ADB")]
		[FieldOffset(Offset = "0x100")]
		protected string m_CSTotalRound;

		// Token: 0x04008ADC RID: 35548
		[Token(Token = "0x4008ADC")]
		[FieldOffset(Offset = "0x108")]
		protected string m_CSInitCoin;

		// Token: 0x04008ADD RID: 35549
		[Token(Token = "0x4008ADD")]
		[FieldOffset(Offset = "0x110")]
		protected string m_DropInfo;

		// Token: 0x04008ADE RID: 35550
		[Token(Token = "0x4008ADE")]
		[FieldOffset(Offset = "0x118")]
		protected bool m_OBEnabled;

		// Token: 0x04008ADF RID: 35551
		[Token(Token = "0x4008ADF")]
		[FieldOffset(Offset = "0x119")]
		protected bool m_EmulatorCheck;

		// Token: 0x04008AE0 RID: 35552
		[Token(Token = "0x4008AE0")]
		[FieldOffset(Offset = "0x11C")]
		protected uint m_VisualStyle;

		// Token: 0x04008AE1 RID: 35553
		[Token(Token = "0x4008AE1")]
		[FieldOffset(Offset = "0x120")]
		protected uint m_RoomSetting;

		// Token: 0x04008AE2 RID: 35554
		[Token(Token = "0x4008AE2")]
		[FieldOffset(Offset = "0x124")]
		protected uint m_RoomSetting2;

		// Token: 0x04008AE3 RID: 35555
		[Token(Token = "0x4008AE3")]
		[FieldOffset(Offset = "0x128")]
		protected bool m_RoleCheck;

		// Token: 0x04008AE4 RID: 35556
		[Token(Token = "0x4008AE4")]
		[FieldOffset(Offset = "0x130")]
		protected UIStandardTabController m_TabCtrl;

		// Token: 0x04008AE5 RID: 35557
		[Token(Token = "0x4008AE5")]
		[FieldOffset(Offset = "0x138")]
		protected UIRoomToggleBtnTemplateController m_WeatherCtrl;

		// Token: 0x04008AE6 RID: 35558
		[Token(Token = "0x4008AE6")]
		[FieldOffset(Offset = "0x140")]
		protected UIRoomToggleBtnTemplateController m_LimitedAmmoCtrl;

		// Token: 0x04008AE7 RID: 35559
		[Token(Token = "0x4008AE7")]
		[FieldOffset(Offset = "0x148")]
		protected UIRoomToggleBtnTemplateController m_FallDamageCtrl;

		// Token: 0x04008AE8 RID: 35560
		[Token(Token = "0x4008AE8")]
		[FieldOffset(Offset = "0x150")]
		protected UIRoomToggleBtnTemplateController m_LoadoutCtrl;

		// Token: 0x04008AE9 RID: 35561
		[Token(Token = "0x4008AE9")]
		[FieldOffset(Offset = "0x158")]
		protected UIRoomToggleBtnTemplateController m_AirdropCtrl;

		// Token: 0x04008AEA RID: 35562
		[Token(Token = "0x4008AEA")]
		[FieldOffset(Offset = "0x160")]
		protected UIRoomToggleBtnTemplateController m_SkillCtrl;

		// Token: 0x04008AEB RID: 35563
		[Token(Token = "0x4008AEB")]
		[FieldOffset(Offset = "0x168")]
		protected UIRoomToggleBtnTemplateController m_VehicleCtrl;

		// Token: 0x04008AEC RID: 35564
		[Token(Token = "0x4008AEC")]
		[FieldOffset(Offset = "0x170")]
		protected UIRoomToggleBtnTemplateController m_UAVCtrl;

		// Token: 0x04008AED RID: 35565
		[Token(Token = "0x4008AED")]
		[FieldOffset(Offset = "0x178")]
		protected UIRoomToggleBtnTemplateController m_BombCtrl;

		// Token: 0x04008AEE RID: 35566
		[Token(Token = "0x4008AEE")]
		[FieldOffset(Offset = "0x180")]
		protected UIRoomToggleBtnTemplateController m_ReplayCtrl;

		// Token: 0x04008AEF RID: 35567
		[Token(Token = "0x4008AEF")]
		[FieldOffset(Offset = "0x188")]
		protected UIRoomToggleBtnTemplateController m_EmulatorCtrl;

		// Token: 0x04008AF0 RID: 35568
		[Token(Token = "0x4008AF0")]
		[FieldOffset(Offset = "0x190")]
		protected UIRoomToggleBtnTemplateController m_ZeppelinCtrl;

		// Token: 0x04008AF1 RID: 35569
		[Token(Token = "0x4008AF1")]
		[FieldOffset(Offset = "0x198")]
		protected UIRoomToggleBtnTemplateController m_HideClothCtrl;

		// Token: 0x04008AF2 RID: 35570
		[Token(Token = "0x4008AF2")]
		[FieldOffset(Offset = "0x1A0")]
		protected UIRoomDropListTemplateController m_MembersCtrl;

		// Token: 0x04008AF3 RID: 35571
		[Token(Token = "0x4008AF3")]
		[FieldOffset(Offset = "0x1A8")]
		protected UIRoomDropListTemplateController m_SpectatorsCtrl;

		// Token: 0x04008AF4 RID: 35572
		[Token(Token = "0x4008AF4")]
		[FieldOffset(Offset = "0x1B0")]
		protected UIRoomDropListTemplateController m_HPCtrl;

		// Token: 0x04008AF5 RID: 35573
		[Token(Token = "0x4008AF5")]
		[FieldOffset(Offset = "0x1B8")]
		protected UIRoomDropListTemplateController m_EPCtrl;

		// Token: 0x04008AF6 RID: 35574
		[Token(Token = "0x4008AF6")]
		[FieldOffset(Offset = "0x1C0")]
		protected UIRoomDropListTemplateController m_SpeedCtrl;

		// Token: 0x04008AF7 RID: 35575
		[Token(Token = "0x4008AF7")]
		[FieldOffset(Offset = "0x1C8")]
		protected UIRoomDropListTemplateController m_JumpHeghtCtrl;

		// Token: 0x04008AF8 RID: 35576
		[Token(Token = "0x4008AF8")]
		[FieldOffset(Offset = "0x1D0")]
		protected UIRoomDropListTemplateController m_CSTotalRoundCtrl;

		// Token: 0x04008AF9 RID: 35577
		[Token(Token = "0x4008AF9")]
		[FieldOffset(Offset = "0x1D8")]
		protected UIRoomDropListTemplateController m_CSInitCoinCtrl;

		// Token: 0x04008AFA RID: 35578
		[Token(Token = "0x4008AFA")]
		[FieldOffset(Offset = "0x1E0")]
		protected UIPopMenuSmallControler m_SelectModePopMenuSmallCtrl;

		// Token: 0x04008AFB RID: 35579
		[Token(Token = "0x4008AFB")]
		[FieldOffset(Offset = "0x1E8")]
		protected UIPopMenuSmallControler m_DropModePopMenuSmallCtrl;

		// Token: 0x04008AFC RID: 35580
		[Token(Token = "0x4008AFC")]
		[FieldOffset(Offset = "0x1F0")]
		protected UIRoomCardListController m_RoomCardCtrl;

		// Token: 0x04008AFD RID: 35581
		[Token(Token = "0x4008AFD")]
		[FieldOffset(Offset = "0x1F8")]
		protected uint m_RoomType;

		// Token: 0x04008AFE RID: 35582
		[Token(Token = "0x4008AFE")]
		[FieldOffset(Offset = "0x200")]
		protected UIRoomToggleBtnTemplateController m_PowerGunCtrl;

		// Token: 0x04008AFF RID: 35583
		[Token(Token = "0x4008AFF")]
		[FieldOffset(Offset = "0x208")]
		protected UICreateRoomSettingCSAdController m_SettingCSAdCtrl;

		// Token: 0x04008B00 RID: 35584
		[Token(Token = "0x4008B00")]
		[FieldOffset(Offset = "0x210")]
		private int m_RoomDropListBaseDepth;

		// Token: 0x04008B01 RID: 35585
		[Token(Token = "0x4008B01")]
		protected const int ROOM_CODE_MAX_LENGTH = 10;

		// Token: 0x04008B02 RID: 35586
		[Token(Token = "0x4008B02")]
		[FieldOffset(Offset = "0x214")]
		protected bool m_IsSettingController;

		// Token: 0x04008B03 RID: 35587
		[Token(Token = "0x4008B03")]
		[FieldOffset(Offset = "0x218")]
		protected List<uint> m_MapIdList;

		// Token: 0x04008B04 RID: 35588
		[Token(Token = "0x4008B04")]
		[FieldOffset(Offset = "0x220")]
		private List<UICreateRoomMapItem> m_MapItemList;

		// Token: 0x02001770 RID: 6000
		[Token(Token = "0x2001770")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F210C", Offset = "0x10F210C")]
		private sealed class <>c__DisplayClass112_0
		{
			// Token: 0x060071A3 RID: 29091 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60071A3")]
			[Address(RVA = "0x1B9F180", Offset = "0x1B9F180", VA = "0x7BBC39F180")]
			public <>c__DisplayClass112_0()
			{
			}

			// Token: 0x060071A4 RID: 29092 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60071A4")]
			[Address(RVA = "0x1B9F188", Offset = "0x1B9F188", VA = "0x7BBC39F188")]
			internal void <ShowNormalConfirmPop>b__1()
			{
			}

			// Token: 0x04008B05 RID: 35589
			[Token(Token = "0x4008B05")]
			[FieldOffset(Offset = "0x10")]
			public RoomParams param;

			// Token: 0x04008B06 RID: 35590
			[Token(Token = "0x4008B06")]
			[FieldOffset(Offset = "0x18")]
			public UICreateRoomController <>4__this;
		}
	}
}
