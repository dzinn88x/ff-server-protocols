using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001B2E RID: 6958
	[Token(Token = "0x2001B2E")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F966C", Offset = "0x10F966C")]
	public class UIProfilePlayerPreferenceSettingPopWndController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x0600950F RID: 38159 RVA: 0x00027630 File Offset: 0x00025830
		[Token(Token = "0x600950F")]
		[Address(RVA = "0x1FE3CFC", Offset = "0x1FE3CFC", VA = "0x7BBC7E3CFC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009510 RID: 38160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009510")]
		[Address(RVA = "0x1FE3D4C", Offset = "0x1FE3D4C", VA = "0x7BBC7E3D4C", Slot = "28")]
		public override string Rule()
		{
			return null;
		}

		// Token: 0x06009511 RID: 38161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009511")]
		[Address(RVA = "0x1FE3DF8", Offset = "0x1FE3DF8", VA = "0x7BBC7E3DF8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009512 RID: 38162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009512")]
		[Address(RVA = "0x1FE7160", Offset = "0x1FE7160", VA = "0x7BBC7E7160")]
		private void OnPublicToogleClick()
		{
		}

		// Token: 0x06009513 RID: 38163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009513")]
		[Address(RVA = "0x1FE71D8", Offset = "0x1FE71D8", VA = "0x7BBC7E71D8")]
		private void OnPrivateToogleClick()
		{
		}

		// Token: 0x06009514 RID: 38164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009514")]
		[Address(RVA = "0x1FE7250", Offset = "0x1FE7250", VA = "0x7BBC7E7250")]
		private void RefreshPrivateInfo()
		{
		}

		// Token: 0x06009515 RID: 38165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009515")]
		[Address(RVA = "0x1FE7664", Offset = "0x1FE7664", VA = "0x7BBC7E7664")]
		public void InitCloseUI()
		{
		}

		// Token: 0x06009516 RID: 38166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009516")]
		[Address(RVA = "0x1FE77A0", Offset = "0x1FE77A0", VA = "0x7BBC7E77A0")]
		private void OnMyClose()
		{
		}

		// Token: 0x06009517 RID: 38167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009517")]
		[Address(RVA = "0x1FE786C", Offset = "0x1FE786C", VA = "0x7BBC7E786C")]
		private void OnBattleToggleClick()
		{
		}

		// Token: 0x06009518 RID: 38168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009518")]
		[Address(RVA = "0x1FE4830", Offset = "0x1FE4830", VA = "0x7BBC7E4830")]
		private void InitTagString()
		{
		}

		// Token: 0x06009519 RID: 38169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009519")]
		[Address(RVA = "0x1FE5280", Offset = "0x1FE5280", VA = "0x7BBC7E5280")]
		private void InitDefaultTagString()
		{
		}

		// Token: 0x0600951A RID: 38170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600951A")]
		[Address(RVA = "0x1FE5944", Offset = "0x1FE5944", VA = "0x7BBC7E5944")]
		private void InitPopMenu()
		{
		}

		// Token: 0x0600951B RID: 38171 RVA: 0x00027648 File Offset: 0x00025848
		[Token(Token = "0x600951B")]
		[Address(RVA = "0x1FE7CB0", Offset = "0x1FE7CB0", VA = "0x7BBC7E7CB0")]
		private int GetOnlineTimeIndex(string str)
		{
			return 0;
		}

		// Token: 0x0600951C RID: 38172 RVA: 0x00027660 File Offset: 0x00025860
		[Token(Token = "0x600951C")]
		[Address(RVA = "0x1FE7BE0", Offset = "0x1FE7BE0", VA = "0x7BBC7E7BE0")]
		private int GetActiveTimeIndex(string str)
		{
			return 0;
		}

		// Token: 0x0600951D RID: 38173 RVA: 0x00027678 File Offset: 0x00025878
		[Token(Token = "0x600951D")]
		[Address(RVA = "0x1FE7B10", Offset = "0x1FE7B10", VA = "0x7BBC7E7B10")]
		private int GetModelPreferIndex(string str)
		{
			return 0;
		}

		// Token: 0x0600951E RID: 38174 RVA: 0x00027690 File Offset: 0x00025890
		[Token(Token = "0x600951E")]
		[Address(RVA = "0x1FE7D80", Offset = "0x1FE7D80", VA = "0x7BBC7E7D80")]
		private int GetModelChooseIndex(string str)
		{
			return 0;
		}

		// Token: 0x0600951F RID: 38175 RVA: 0x000276A8 File Offset: 0x000258A8
		[Token(Token = "0x600951F")]
		[Address(RVA = "0x1FE7E50", Offset = "0x1FE7E50", VA = "0x7BBC7E7E50")]
		private int GetSexIndex(string str)
		{
			return 0;
		}

		// Token: 0x06009520 RID: 38176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009520")]
		[Address(RVA = "0x1FE55F0", Offset = "0x1FE55F0", VA = "0x7BBC7E55F0")]
		private void InitSelectedState()
		{
		}

		// Token: 0x06009521 RID: 38177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009521")]
		[Address(RVA = "0x1FE6D78", Offset = "0x1FE6D78", VA = "0x7BBC7E6D78")]
		private void TryShowGuide()
		{
		}

		// Token: 0x06009522 RID: 38178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009522")]
		[Address(RVA = "0x1FE7F20", Offset = "0x1FE7F20", VA = "0x7BBC7E7F20")]
		private void OnMainGuideClose()
		{
		}

		// Token: 0x06009523 RID: 38179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009523")]
		[Address(RVA = "0x1FE818C", Offset = "0x1FE818C", VA = "0x7BBC7E818C")]
		private void OnTagShowClick()
		{
		}

		// Token: 0x06009524 RID: 38180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009524")]
		[Address(RVA = "0x1FE8650", Offset = "0x1FE8650", VA = "0x7BBC7E8650")]
		private void OnSocialToogleCLick()
		{
		}

		// Token: 0x06009525 RID: 38181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009525")]
		[Address(RVA = "0x1FE8744", Offset = "0x1FE8744", VA = "0x7BBC7E8744")]
		private void OnBattleTagClose()
		{
		}

		// Token: 0x06009526 RID: 38182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009526")]
		[Address(RVA = "0x1FE8BD8", Offset = "0x1FE8BD8", VA = "0x7BBC7E8BD8")]
		private void OnSocailTagClose()
		{
		}

		// Token: 0x06009527 RID: 38183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009527")]
		[Address(RVA = "0x1FE8EC8", Offset = "0x1FE8EC8", VA = "0x7BBC7E8EC8")]
		private void OnGetFocus()
		{
		}

		// Token: 0x06009528 RID: 38184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009528")]
		[Address(RVA = "0x1FE8F84", Offset = "0x1FE8F84", VA = "0x7BBC7E8F84")]
		private void OnLostFocus()
		{
		}

		// Token: 0x06009529 RID: 38185 RVA: 0x000276C0 File Offset: 0x000258C0
		[Token(Token = "0x6009529")]
		[Address(RVA = "0x1FE9014", Offset = "0x1FE9014", VA = "0x7BBC7E9014")]
		private bool CheckCanSend()
		{
			return default(bool);
		}

		// Token: 0x0600952A RID: 38186 RVA: 0x000276D8 File Offset: 0x000258D8
		[Token(Token = "0x600952A")]
		[Address(RVA = "0x1FE97DC", Offset = "0x1FE97DC", VA = "0x7BBC7E97DC")]
		private bool CheckBattleSend()
		{
			return default(bool);
		}

		// Token: 0x0600952B RID: 38187 RVA: 0x000276F0 File Offset: 0x000258F0
		[Token(Token = "0x600952B")]
		[Address(RVA = "0x1FE9990", Offset = "0x1FE9990", VA = "0x7BBC7E9990")]
		private bool CheckSocialSend()
		{
			return default(bool);
		}

		// Token: 0x0600952C RID: 38188 RVA: 0x00027708 File Offset: 0x00025908
		[Token(Token = "0x600952C")]
		[Address(RVA = "0x1FE946C", Offset = "0x1FE946C", VA = "0x7BBC7E946C")]
		private ESocial.ModePrefer GetPreferBySelect()
		{
			return ESocial.ModePrefer.ModePrefer_NONE;
		}

		// Token: 0x0600952D RID: 38189 RVA: 0x00027720 File Offset: 0x00025920
		[Token(Token = "0x600952D")]
		[Address(RVA = "0x1FE951C", Offset = "0x1FE951C", VA = "0x7BBC7E951C")]
		private ESocial.Gender GetGenderBySelect()
		{
			return ESocial.Gender.Gender_NONE;
		}

		// Token: 0x0600952E RID: 38190 RVA: 0x00027738 File Offset: 0x00025938
		[Token(Token = "0x600952E")]
		[Address(RVA = "0x1FE95CC", Offset = "0x1FE95CC", VA = "0x7BBC7E95CC")]
		private ESocial.TimeActive GetActiveBySelect()
		{
			return ESocial.TimeActive.TimeActive_NONE;
		}

		// Token: 0x0600952F RID: 38191 RVA: 0x00027750 File Offset: 0x00025950
		[Token(Token = "0x600952F")]
		[Address(RVA = "0x1FE967C", Offset = "0x1FE967C", VA = "0x7BBC7E967C")]
		private ESocial.TimeOnline GetTimeBySelect()
		{
			return ESocial.TimeOnline.TimeOnline_NONE;
		}

		// Token: 0x06009530 RID: 38192 RVA: 0x00027768 File Offset: 0x00025968
		[Token(Token = "0x6009530")]
		[Address(RVA = "0x1FE972C", Offset = "0x1FE972C", VA = "0x7BBC7E972C")]
		private ESocial.RankShow GetShowBySelect()
		{
			return ESocial.RankShow.RankShow_NONE;
		}

		// Token: 0x06009531 RID: 38193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009531")]
		[Address(RVA = "0x1FE9B44", Offset = "0x1FE9B44", VA = "0x7BBC7E9B44", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06009532 RID: 38194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009532")]
		[Address(RVA = "0x1FEA0C8", Offset = "0x1FEA0C8", VA = "0x7BBC7EA0C8", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06009533 RID: 38195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009533")]
		[Address(RVA = "0x1FEA244", Offset = "0x1FEA244", VA = "0x7BBC7EA244")]
		private void OnBtnRenameClick()
		{
		}

		// Token: 0x06009534 RID: 38196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009534")]
		[Address(RVA = "0x1FEA314", Offset = "0x1FEA314", VA = "0x7BBC7EA314")]
		private void OnSelectLanguageClick()
		{
		}

		// Token: 0x06009535 RID: 38197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009535")]
		[Address(RVA = "0x1FEA3F0", Offset = "0x1FEA3F0", VA = "0x7BBC7EA3F0")]
		private void InitLanguageList()
		{
		}

		// Token: 0x06009536 RID: 38198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009536")]
		[Address(RVA = "0x1FE54BC", Offset = "0x1FE54BC", VA = "0x7BBC7E54BC")]
		private void InitTagLevelUpReview()
		{
		}

		// Token: 0x06009537 RID: 38199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009537")]
		[Address(RVA = "0x1FEA89C", Offset = "0x1FEA89C", VA = "0x7BBC7EA89C")]
		private void GenerateSexList()
		{
		}

		// Token: 0x06009538 RID: 38200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009538")]
		[Address(RVA = "0x1FEAC04", Offset = "0x1FEAC04", VA = "0x7BBC7EAC04")]
		private void GenerateDefaultShowList()
		{
		}

		// Token: 0x06009539 RID: 38201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009539")]
		[Address(RVA = "0x1FEAF6C", Offset = "0x1FEAF6C", VA = "0x7BBC7EAF6C")]
		private void GenerateOnLineTimeList()
		{
		}

		// Token: 0x0600953A RID: 38202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600953A")]
		[Address(RVA = "0x1FEB2D4", Offset = "0x1FEB2D4", VA = "0x7BBC7EB2D4")]
		private void GenerateActiveTimeList()
		{
		}

		// Token: 0x0600953B RID: 38203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600953B")]
		[Address(RVA = "0x1FEB63C", Offset = "0x1FEB63C", VA = "0x7BBC7EB63C")]
		private void GenerateModePreferList()
		{
		}

		// Token: 0x0600953C RID: 38204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600953C")]
		[Address(RVA = "0x1FEB9A4", Offset = "0x1FEB9A4", VA = "0x7BBC7EB9A4")]
		private void OnLocLanSelect(object obj)
		{
		}

		// Token: 0x0600953D RID: 38205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600953D")]
		[Address(RVA = "0x1FEBACC", Offset = "0x1FEBACC", VA = "0x7BBC7EBACC")]
		private void OnSexSelect(object obj)
		{
		}

		// Token: 0x0600953E RID: 38206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600953E")]
		[Address(RVA = "0x1FEBBF0", Offset = "0x1FEBBF0", VA = "0x7BBC7EBBF0")]
		private void OnDefaultShowSelect(object obj)
		{
		}

		// Token: 0x0600953F RID: 38207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600953F")]
		[Address(RVA = "0x1FEBD14", Offset = "0x1FEBD14", VA = "0x7BBC7EBD14")]
		private void OnOnLineTimeSelect(object obj)
		{
		}

		// Token: 0x06009540 RID: 38208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009540")]
		[Address(RVA = "0x1FEBE38", Offset = "0x1FEBE38", VA = "0x7BBC7EBE38")]
		private void OnActiveTimeSelect(object obj)
		{
		}

		// Token: 0x06009541 RID: 38209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009541")]
		[Address(RVA = "0x1FEBF5C", Offset = "0x1FEBF5C", VA = "0x7BBC7EBF5C")]
		private void OnModePreferSelect(object obj)
		{
		}

		// Token: 0x06009542 RID: 38210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009542")]
		[Address(RVA = "0x1FEC080", Offset = "0x1FEC080", VA = "0x7BBC7EC080")]
		private void OnSignatureChange()
		{
		}

		// Token: 0x06009543 RID: 38211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009543")]
		[Address(RVA = "0x1FEC084", Offset = "0x1FEC084", VA = "0x7BBC7EC084")]
		private void OnEquipBattleTagClick()
		{
		}

		// Token: 0x06009544 RID: 38212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009544")]
		[Address(RVA = "0x1FEC7F0", Offset = "0x1FEC7F0", VA = "0x7BBC7EC7F0")]
		private void OnEquipSocialTagClick()
		{
		}

		// Token: 0x06009545 RID: 38213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009545")]
		[Address(RVA = "0x1FECCC8", Offset = "0x1FECCC8", VA = "0x7BBC7ECCC8")]
		private void OnUnEquipBattleTagClick()
		{
		}

		// Token: 0x06009546 RID: 38214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009546")]
		[Address(RVA = "0x1FECE64", Offset = "0x1FECE64", VA = "0x7BBC7ECE64")]
		private void OnUnEquipSocialTagClick()
		{
		}

		// Token: 0x06009547 RID: 38215 RVA: 0x00027780 File Offset: 0x00025980
		[Token(Token = "0x6009547")]
		[Address(RVA = "0x1FEC304", Offset = "0x1FEC304", VA = "0x7BBC7EC304")]
		private uint CalcBattleTagShowNum()
		{
			return 0U;
		}

		// Token: 0x06009548 RID: 38216 RVA: 0x00027798 File Offset: 0x00025998
		[Token(Token = "0x6009548")]
		[Address(RVA = "0x1FECA70", Offset = "0x1FECA70", VA = "0x7BBC7ECA70")]
		private uint CalcSocialTagShowNum()
		{
			return 0U;
		}

		// Token: 0x06009549 RID: 38217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009549")]
		[Address(RVA = "0x1FED000", Offset = "0x1FED000", VA = "0x7BBC7ED000")]
		private void UpdateData()
		{
		}

		// Token: 0x0600954A RID: 38218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600954A")]
		[Address(RVA = "0x1FED24C", Offset = "0x1FED24C", VA = "0x7BBC7ED24C")]
		private void OnTagClick(params object[] param)
		{
		}

		// Token: 0x0600954B RID: 38219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600954B")]
		[Address(RVA = "0x1FEDED0", Offset = "0x1FEDED0", VA = "0x7BBC7EDED0")]
		private void RefreshBattleTag()
		{
		}

		// Token: 0x0600954C RID: 38220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600954C")]
		[Address(RVA = "0x1FEE700", Offset = "0x1FEE700", VA = "0x7BBC7EE700")]
		private void RefreshSocialTag()
		{
		}

		// Token: 0x0600954D RID: 38221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600954D")]
		[Address(RVA = "0x1FEEA80", Offset = "0x1FEEA80", VA = "0x7BBC7EEA80")]
		public void RefreshAccoutId(ulong accid)
		{
		}

		// Token: 0x0600954E RID: 38222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600954E")]
		[Address(RVA = "0x1FEC568", Offset = "0x1FEC568", VA = "0x7BBC7EC568")]
		private void RefreshSocialBattleLabel()
		{
		}

		// Token: 0x0600954F RID: 38223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600954F")]
		[Address(RVA = "0x1FEE42C", Offset = "0x1FEE42C", VA = "0x7BBC7EE42C")]
		private void UpdateBattleTag()
		{
		}

		// Token: 0x06009550 RID: 38224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009550")]
		[Address(RVA = "0x1FEC3F4", Offset = "0x1FEC3F4", VA = "0x7BBC7EC3F4")]
		private void RefreshBattleTagL()
		{
		}

		// Token: 0x06009551 RID: 38225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009551")]
		[Address(RVA = "0x1FECB60", Offset = "0x1FECB60", VA = "0x7BBC7ECB60")]
		private void RefreshSocialTagL()
		{
		}

		// Token: 0x06009552 RID: 38226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009552")]
		[Address(RVA = "0x1FEEAE4", Offset = "0x1FEEAE4", VA = "0x7BBC7EEAE4")]
		private void UpdateSocialTag()
		{
		}

		// Token: 0x06009553 RID: 38227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009553")]
		[Address(RVA = "0x1FED7E0", Offset = "0x1FED7E0", VA = "0x7BBC7ED7E0")]
		private void RefreshBattleTagDetailPanel(PlayerBattleTagData data)
		{
		}

		// Token: 0x06009554 RID: 38228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009554")]
		[Address(RVA = "0x1FED4CC", Offset = "0x1FED4CC", VA = "0x7BBC7ED4CC")]
		private void RefreshSocialTagDetailPanel(PlayerSocailTagData data)
		{
		}

		// Token: 0x06009555 RID: 38229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009555")]
		[Address(RVA = "0x1FEEC30", Offset = "0x1FEEC30", VA = "0x7BBC7EEC30")]
		private void OnLevelUpTipsClick()
		{
		}

		// Token: 0x06009556 RID: 38230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009556")]
		[Address(RVA = "0x1FEEB30", Offset = "0x1FEEB30", VA = "0x7BBC7EEB30")]
		private void RefreshPreviewTag(PlayerBattleTagData data)
		{
		}

		// Token: 0x06009557 RID: 38231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009557")]
		[Address(RVA = "0x1FEEE90", Offset = "0x1FEEE90", VA = "0x7BBC7EEE90", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06009558 RID: 38232 RVA: 0x000277B0 File Offset: 0x000259B0
		[Token(Token = "0x6009558")]
		[Address(RVA = "0x1FEF058", Offset = "0x1FEF058", VA = "0x7BBC7EF058", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06009559 RID: 38233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009559")]
		[Address(RVA = "0x1FE62BC", Offset = "0x1FE62BC", VA = "0x7BBC7E62BC")]
		private void InitTag()
		{
		}

		// Token: 0x0600955A RID: 38234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600955A")]
		[Address(RVA = "0x1FEF0BC", Offset = "0x1FEF0BC", VA = "0x7BBC7EF0BC")]
		public UIProfilePlayerPreferenceSettingPopWndController()
		{
		}

		// Token: 0x0600955B RID: 38235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600955B")]
		[Address(RVA = "0x1FEF2C8", Offset = "0x1FEF2C8", VA = "0x7BBC7EF2C8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144C20", Offset = "0x1144C20")]
		private void <OnUIInit>b__49_0()
		{
		}

		// Token: 0x0600955C RID: 38236 RVA: 0x000277C8 File Offset: 0x000259C8
		[Token(Token = "0x600955C")]
		[Address(RVA = "0x1FEF2CC", Offset = "0x1FEF2CC", VA = "0x7BBC7EF2CC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144C30", Offset = "0x1144C30")]
		private bool <GetPreferBySelect>b__76_0(string X)
		{
			return default(bool);
		}

		// Token: 0x0600955D RID: 38237 RVA: 0x000277E0 File Offset: 0x000259E0
		[Token(Token = "0x600955D")]
		[Address(RVA = "0x1FEF2E0", Offset = "0x1FEF2E0", VA = "0x7BBC7EF2E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144C40", Offset = "0x1144C40")]
		private bool <GetGenderBySelect>b__77_0(string X)
		{
			return default(bool);
		}

		// Token: 0x0600955E RID: 38238 RVA: 0x000277F8 File Offset: 0x000259F8
		[Token(Token = "0x600955E")]
		[Address(RVA = "0x1FEF2F4", Offset = "0x1FEF2F4", VA = "0x7BBC7EF2F4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144C50", Offset = "0x1144C50")]
		private bool <GetActiveBySelect>b__78_0(string X)
		{
			return default(bool);
		}

		// Token: 0x0600955F RID: 38239 RVA: 0x00027810 File Offset: 0x00025A10
		[Token(Token = "0x600955F")]
		[Address(RVA = "0x1FEF308", Offset = "0x1FEF308", VA = "0x7BBC7EF308")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144C60", Offset = "0x1144C60")]
		private bool <GetTimeBySelect>b__79_0(string X)
		{
			return default(bool);
		}

		// Token: 0x06009560 RID: 38240 RVA: 0x00027828 File Offset: 0x00025A28
		[Token(Token = "0x6009560")]
		[Address(RVA = "0x1FEF31C", Offset = "0x1FEF31C", VA = "0x7BBC7EF31C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144C70", Offset = "0x1144C70")]
		private bool <GetShowBySelect>b__80_0(string X)
		{
			return default(bool);
		}

		// Token: 0x04009E6A RID: 40554
		[Token(Token = "0x4009E6A")]
		[FieldOffset(Offset = "0x98")]
		private ulong m_accoutid;

		// Token: 0x04009E6B RID: 40555
		[Token(Token = "0x4009E6B")]
		[FieldOffset(Offset = "0xA0")]
		private UIProfilePlayerPreferenceSettingPopWndView m_View;

		// Token: 0x04009E6C RID: 40556
		[Token(Token = "0x4009E6C")]
		[FieldOffset(Offset = "0xA8")]
		private LoginRes m_UserData;

		// Token: 0x04009E6D RID: 40557
		[Token(Token = "0x4009E6D")]
		[FieldOffset(Offset = "0xB0")]
		private SocialBasicInfo m_SocailBasicInfo;

		// Token: 0x04009E6E RID: 40558
		[Token(Token = "0x4009E6E")]
		private const int TOGGLE_GROUP_ID = 117;

		// Token: 0x04009E6F RID: 40559
		[Token(Token = "0x4009E6F")]
		[FieldOffset(Offset = "0xB8")]
		private LocLang m_SelectedLan;

		// Token: 0x04009E70 RID: 40560
		[Token(Token = "0x4009E70")]
		[FieldOffset(Offset = "0xC0")]
		private string m_SelectedSex;

		// Token: 0x04009E71 RID: 40561
		[Token(Token = "0x4009E71")]
		[FieldOffset(Offset = "0xC8")]
		private string m_SelectedDefaultShow;

		// Token: 0x04009E72 RID: 40562
		[Token(Token = "0x4009E72")]
		[FieldOffset(Offset = "0xD0")]
		private string m_SelectedOnLineTime;

		// Token: 0x04009E73 RID: 40563
		[Token(Token = "0x4009E73")]
		[FieldOffset(Offset = "0xD8")]
		private string m_SelectedActiveTime;

		// Token: 0x04009E74 RID: 40564
		[Token(Token = "0x4009E74")]
		[FieldOffset(Offset = "0xE0")]
		private string m_SelectedModePrefer;

		// Token: 0x04009E75 RID: 40565
		[Token(Token = "0x4009E75")]
		[FieldOffset(Offset = "0xE8")]
		private string m_Signature;

		// Token: 0x04009E76 RID: 40566
		[Token(Token = "0x4009E76")]
		[FieldOffset(Offset = "0xF0")]
		private string m_DefaultSignature;

		// Token: 0x04009E77 RID: 40567
		[Token(Token = "0x4009E77")]
		[FieldOffset(Offset = "0xF8")]
		private List<PopMenuData> m_LanDataList;

		// Token: 0x04009E78 RID: 40568
		[Token(Token = "0x4009E78")]
		[FieldOffset(Offset = "0x100")]
		private List<PopMenuData> m_SexDataList;

		// Token: 0x04009E79 RID: 40569
		[Token(Token = "0x4009E79")]
		[FieldOffset(Offset = "0x108")]
		private List<PopMenuData> m_DefaultShowDataList;

		// Token: 0x04009E7A RID: 40570
		[Token(Token = "0x4009E7A")]
		[FieldOffset(Offset = "0x110")]
		private List<PopMenuData> m_OnLineTimeDataList;

		// Token: 0x04009E7B RID: 40571
		[Token(Token = "0x4009E7B")]
		[FieldOffset(Offset = "0x118")]
		private List<PopMenuData> m_ActiveTimeDataList;

		// Token: 0x04009E7C RID: 40572
		[Token(Token = "0x4009E7C")]
		[FieldOffset(Offset = "0x120")]
		private List<PopMenuData> m_ModePreferDataList;

		// Token: 0x04009E7D RID: 40573
		[Token(Token = "0x4009E7D")]
		[FieldOffset(Offset = "0x128")]
		private List<string> m_SexList;

		// Token: 0x04009E7E RID: 40574
		[Token(Token = "0x4009E7E")]
		[FieldOffset(Offset = "0x130")]
		private List<string> m_DefaultShowList;

		// Token: 0x04009E7F RID: 40575
		[Token(Token = "0x4009E7F")]
		[FieldOffset(Offset = "0x138")]
		private List<string> m_OnLineTimeList;

		// Token: 0x04009E80 RID: 40576
		[Token(Token = "0x4009E80")]
		[FieldOffset(Offset = "0x140")]
		private List<string> m_ActiveTimeList;

		// Token: 0x04009E81 RID: 40577
		[Token(Token = "0x4009E81")]
		[FieldOffset(Offset = "0x148")]
		private List<string> m_ModePreferList;

		// Token: 0x04009E82 RID: 40578
		[Token(Token = "0x4009E82")]
		[FieldOffset(Offset = "0x150")]
		private UIPopMenuSmallControler m_SexPop;

		// Token: 0x04009E83 RID: 40579
		[Token(Token = "0x4009E83")]
		[FieldOffset(Offset = "0x158")]
		private UIPopMenuSmallControler m_DefaultShowPop;

		// Token: 0x04009E84 RID: 40580
		[Token(Token = "0x4009E84")]
		[FieldOffset(Offset = "0x160")]
		private UIPopMenuSmallControler m_OnLineTimePop;

		// Token: 0x04009E85 RID: 40581
		[Token(Token = "0x4009E85")]
		[FieldOffset(Offset = "0x168")]
		private UIPopMenuSmallControler m_ActiveTimePop;

		// Token: 0x04009E86 RID: 40582
		[Token(Token = "0x4009E86")]
		[FieldOffset(Offset = "0x170")]
		private UIPopMenuSmallControler m_ModePreferPop;

		// Token: 0x04009E87 RID: 40583
		[Token(Token = "0x4009E87")]
		[FieldOffset(Offset = "0x178")]
		private readonly float GREY_ALPHA;

		// Token: 0x04009E88 RID: 40584
		[Token(Token = "0x4009E88")]
		[FieldOffset(Offset = "0x180")]
		private UISelectLanguageController m_UISelectLanguageController;

		// Token: 0x04009E89 RID: 40585
		[Token(Token = "0x4009E89")]
		[FieldOffset(Offset = "0x188")]
		private List<UIProfileTagController> m_SocailTagList;

		// Token: 0x04009E8A RID: 40586
		[Token(Token = "0x4009E8A")]
		[FieldOffset(Offset = "0x190")]
		private List<UIProfileTagController> m_BattleTagList;

		// Token: 0x04009E8B RID: 40587
		[Token(Token = "0x4009E8B")]
		[FieldOffset(Offset = "0x198")]
		private List<UIProfileTagSmallController> m_PreviewTagList;

		// Token: 0x04009E8C RID: 40588
		[Token(Token = "0x4009E8C")]
		[FieldOffset(Offset = "0x1A0")]
		private bool m_NeedHide;

		// Token: 0x04009E8D RID: 40589
		[Token(Token = "0x4009E8D")]
		[FieldOffset(Offset = "0x1A1")]
		private bool m_OriginHide;

		// Token: 0x04009E8E RID: 40590
		[Token(Token = "0x4009E8E")]
		[FieldOffset(Offset = "0x1A8")]
		private UICommonGuideController m_GuideCtrl;

		// Token: 0x04009E8F RID: 40591
		[Token(Token = "0x4009E8F")]
		[FieldOffset(Offset = "0x1B0")]
		private List<PlayerBattleTagData> m_PlayerBattleTagDataList;

		// Token: 0x04009E90 RID: 40592
		[Token(Token = "0x4009E90")]
		[FieldOffset(Offset = "0x1B8")]
		private List<PlayerSocailTagData> m_PlayerSocialTagDataList;

		// Token: 0x04009E91 RID: 40593
		[Token(Token = "0x4009E91")]
		[FieldOffset(Offset = "0x1C0")]
		private List<PlayerBattleTagData> m_OriginPlayerBattleTagDataList;

		// Token: 0x04009E92 RID: 40594
		[Token(Token = "0x4009E92")]
		[FieldOffset(Offset = "0x1C8")]
		private List<PlayerSocailTagData> m_OrignPlayerSocialTagDataList;

		// Token: 0x04009E93 RID: 40595
		[Token(Token = "0x4009E93")]
		private const string m_EquipShowKey = "T_26_YP_SOCIAL_TAG_SHOW";

		// Token: 0x04009E94 RID: 40596
		[Token(Token = "0x4009E94")]
		private const string m_EquipUnEquipKey = "T_26_YP_SOCIAL_TAG_REMOVE";

		// Token: 0x04009E95 RID: 40597
		[Token(Token = "0x4009E95")]
		private const string m_EquipUnlockKey = "T_26_YP_SOCIAL_TAG_UNLOCK";

		// Token: 0x04009E96 RID: 40598
		[Token(Token = "0x4009E96")]
		[FieldOffset(Offset = "0x1D0")]
		private uint m_SelectedBattleId;

		// Token: 0x04009E97 RID: 40599
		[Token(Token = "0x4009E97")]
		[FieldOffset(Offset = "0x1D4")]
		private uint m_SelectedSocialId;

		// Token: 0x04009E98 RID: 40600
		[Token(Token = "0x4009E98")]
		[FieldOffset(Offset = "0x1D8")]
		private ulong mytime;

		// Token: 0x02001B2F RID: 6959
		[Token(Token = "0x2001B2F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F96A4", Offset = "0x10F96A4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06009562 RID: 38242 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009562")]
			[Address(RVA = "0x1FEF394", Offset = "0x1FEF394", VA = "0x7BBC7EF394")]
			public <>c()
			{
			}

			// Token: 0x06009563 RID: 38243 RVA: 0x00027840 File Offset: 0x00025A40
			[Token(Token = "0x6009563")]
			[Address(RVA = "0x1FEF39C", Offset = "0x1FEF39C", VA = "0x7BBC7EF39C")]
			internal int <UpdateBattleTag>b__111_0(PlayerBattleTagData a, PlayerBattleTagData b)
			{
				return 0;
			}

			// Token: 0x04009E99 RID: 40601
			[Token(Token = "0x4009E99")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIProfilePlayerPreferenceSettingPopWndController.<>c <>9;

			// Token: 0x04009E9A RID: 40602
			[Token(Token = "0x4009E9A")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<PlayerBattleTagData> <>9__111_0;
		}
	}
}
