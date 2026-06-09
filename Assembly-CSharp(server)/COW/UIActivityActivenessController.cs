using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x020013D6 RID: 5078
	[Token(Token = "0x20013D6")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EC070", Offset = "0x10EC070")]
	public class UIActivityActivenessController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x0600533D RID: 21309 RVA: 0x00018E28 File Offset: 0x00017028
		[Token(Token = "0x600533D")]
		[Address(RVA = "0x1A3F698", Offset = "0x1A3F698", VA = "0x7BBC23F698")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600533E RID: 21310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600533E")]
		[Address(RVA = "0x1A3F6E8", Offset = "0x1A3F6E8", VA = "0x7BBC23F6E8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600533F RID: 21311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600533F")]
		[Address(RVA = "0x1A3FC54", Offset = "0x1A3FC54", VA = "0x7BBC23FC54", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06005340 RID: 21312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005340")]
		[Address(RVA = "0x1A3FC30", Offset = "0x1A3FC30", VA = "0x7BBC23FC30")]
		private void Init()
		{
		}

		// Token: 0x06005341 RID: 21313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005341")]
		[Address(RVA = "0x1A3FE80", Offset = "0x1A3FE80", VA = "0x7BBC23FE80")]
		private void Update()
		{
		}

		// Token: 0x06005342 RID: 21314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005342")]
		[Address(RVA = "0x1A410F0", Offset = "0x1A410F0", VA = "0x7BBC2410F0", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06005343 RID: 21315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005343")]
		[Address(RVA = "0x1A3FCFC", Offset = "0x1A3FCFC", VA = "0x7BBC23FCFC")]
		private void RequestActivenessInfo()
		{
		}

		// Token: 0x06005344 RID: 21316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005344")]
		[Address(RVA = "0x1A411E0", Offset = "0x1A411E0", VA = "0x7BBC2411E0")]
		private void SetTaskItemList()
		{
		}

		// Token: 0x06005345 RID: 21317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005345")]
		[Address(RVA = "0x1A3FD30", Offset = "0x1A3FD30", VA = "0x7BBC23FD30")]
		private void SetCountDownLabel()
		{
		}

		// Token: 0x06005346 RID: 21318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005346")]
		[Address(RVA = "0x1A40D4C", Offset = "0x1A40D4C", VA = "0x7BBC240D4C")]
		private void RefreshActivenessProcess()
		{
		}

		// Token: 0x06005347 RID: 21319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005347")]
		[Address(RVA = "0x1A40880", Offset = "0x1A40880", VA = "0x7BBC240880")]
		private void SetActivenessRewardList()
		{
		}

		// Token: 0x06005348 RID: 21320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005348")]
		[Address(RVA = "0x1A3FC7C", Offset = "0x1A3FC7C", VA = "0x7BBC23FC7C")]
		private void SetClaimAllBtn()
		{
		}

		// Token: 0x06005349 RID: 21321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005349")]
		[Address(RVA = "0x1A41FD4", Offset = "0x1A41FD4", VA = "0x7BBC241FD4")]
		private void OnClickClaimAllBtn()
		{
		}

		// Token: 0x0600534A RID: 21322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600534A")]
		[Address(RVA = "0x1A422BC", Offset = "0x1A422BC", VA = "0x7BBC2422BC", Slot = "28")]
		private void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600534B RID: 21323 RVA: 0x00018E40 File Offset: 0x00017040
		[Token(Token = "0x600534B")]
		[Address(RVA = "0x1A423BC", Offset = "0x1A423BC", VA = "0x7BBC2423BC", Slot = "29")]
		private uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600534C RID: 21324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600534C")]
		[Address(RVA = "0x1A42400", Offset = "0x1A42400", VA = "0x7BBC242400")]
		private void OnActivenessChanged(params object[] data)
		{
		}

		// Token: 0x0600534D RID: 21325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600534D")]
		[Address(RVA = "0x1A419D4", Offset = "0x1A419D4", VA = "0x7BBC2419D4")]
		private void RefreshContainerState()
		{
		}

		// Token: 0x0600534E RID: 21326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600534E")]
		[Address(RVA = "0x1A42984", Offset = "0x1A42984", VA = "0x7BBC242984", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x0600534F RID: 21327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600534F")]
		[Address(RVA = "0x1A429EC", Offset = "0x1A429EC", VA = "0x7BBC2429EC")]
		private void OnSliderValueChange(uint activenessValue)
		{
		}

		// Token: 0x06005350 RID: 21328 RVA: 0x00018E58 File Offset: 0x00017058
		[Token(Token = "0x6005350")]
		[Address(RVA = "0x1A42DE0", Offset = "0x1A42DE0", VA = "0x7BBC242DE0")]
		private int ActivenessRewardSort(ClientActivityDesc x, ClientActivityDesc y)
		{
			return 0;
		}

		// Token: 0x06005351 RID: 21329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005351")]
		[Address(RVA = "0x1A41BC0", Offset = "0x1A41BC0", VA = "0x7BBC241BC0")]
		private void SetWeekRewardProcess(bool needInit)
		{
		}

		// Token: 0x06005352 RID: 21330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005352")]
		[Address(RVA = "0x1A403B0", Offset = "0x1A403B0", VA = "0x7BBC2403B0")]
		private void RepostionSliderEffect(float percent)
		{
		}

		// Token: 0x06005353 RID: 21331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005353")]
		[Address(RVA = "0x1A427FC", Offset = "0x1A427FC", VA = "0x7BBC2427FC")]
		private void ShowAddingActivenessEffect()
		{
		}

		// Token: 0x06005354 RID: 21332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005354")]
		[Address(RVA = "0x1A4301C", Offset = "0x1A4301C", VA = "0x7BBC24301C")]
		public UIActivityActivenessController()
		{
		}

		// Token: 0x040078F1 RID: 30961
		[Token(Token = "0x40078F1")]
		[FieldOffset(Offset = "0x58")]
		private UIActivityActivenessContentView m_View;

		// Token: 0x040078F2 RID: 30962
		[Token(Token = "0x40078F2")]
		[FieldOffset(Offset = "0x60")]
		private UIModelActivity m_ModelActivity;

		// Token: 0x040078F3 RID: 30963
		[Token(Token = "0x40078F3")]
		[FieldOffset(Offset = "0x68")]
		private ActivityGroupDesc m_GroupDesc;

		// Token: 0x040078F4 RID: 30964
		[Token(Token = "0x40078F4")]
		[FieldOffset(Offset = "0x70")]
		private ActivenessInfo m_ActivenessInfo;

		// Token: 0x040078F5 RID: 30965
		[Token(Token = "0x40078F5")]
		[FieldOffset(Offset = "0x78")]
		private List<ActivenessReward> m_ActivenessRewardsList;

		// Token: 0x040078F6 RID: 30966
		[Token(Token = "0x40078F6")]
		[FieldOffset(Offset = "0x80")]
		private List<UIActivityActivenessItemController> m_ActivenessTaskList;

		// Token: 0x040078F7 RID: 30967
		[Token(Token = "0x40078F7")]
		[FieldOffset(Offset = "0x88")]
		private List<UIActivityActivenessRewardDescription> m_ActivenessRewardsUI;

		// Token: 0x040078F8 RID: 30968
		[Token(Token = "0x40078F8")]
		[FieldOffset(Offset = "0x90")]
		private List<Vector3> m_weekVfxPos;

		// Token: 0x040078F9 RID: 30969
		[Token(Token = "0x40078F9")]
		[FieldOffset(Offset = "0x98")]
		private List<Vector3> m_weekVfxScal;

		// Token: 0x040078FA RID: 30970
		[Token(Token = "0x40078FA")]
		[FieldOffset(Offset = "0xA0")]
		private List<int> m_weekActivenessLevel;

		// Token: 0x040078FB RID: 30971
		[Token(Token = "0x40078FB")]
		[FieldOffset(Offset = "0xA8")]
		private Vector3 m_SliderEffectPos;

		// Token: 0x040078FC RID: 30972
		[Token(Token = "0x40078FC")]
		[FieldOffset(Offset = "0xB4")]
		private int m_SliderWidth;

		// Token: 0x040078FD RID: 30973
		[Token(Token = "0x40078FD")]
		[FieldOffset(Offset = "0xB8")]
		private uint mNewSliderValue;

		// Token: 0x040078FE RID: 30974
		[Token(Token = "0x40078FE")]
		[FieldOffset(Offset = "0xBC")]
		private uint mOldSliderValue;

		// Token: 0x040078FF RID: 30975
		[Token(Token = "0x40078FF")]
		[FieldOffset(Offset = "0xC0")]
		private uint mMaxSliderValue;

		// Token: 0x04007900 RID: 30976
		[Token(Token = "0x4007900")]
		[FieldOffset(Offset = "0xC4")]
		private bool mNeedShowSliderAdding;

		// Token: 0x04007901 RID: 30977
		[Token(Token = "0x4007901")]
		[FieldOffset(Offset = "0xC8")]
		private Transform mFrom;

		// Token: 0x04007902 RID: 30978
		[Token(Token = "0x4007902")]
		[FieldOffset(Offset = "0xD0")]
		private Transform mTo;

		// Token: 0x04007903 RID: 30979
		[Token(Token = "0x4007903")]
		[FieldOffset(Offset = "0xD8")]
		private float mF1;

		// Token: 0x04007904 RID: 30980
		[Token(Token = "0x4007904")]
		[FieldOffset(Offset = "0xDC")]
		private float mF2;

		// Token: 0x04007905 RID: 30981
		[Token(Token = "0x4007905")]
		[FieldOffset(Offset = "0xE0")]
		private float mMoveTime;

		// Token: 0x04007906 RID: 30982
		[Token(Token = "0x4007906")]
		[FieldOffset(Offset = "0xE4")]
		private bool mShowingEffectMove;

		// Token: 0x04007907 RID: 30983
		[Token(Token = "0x4007907")]
		[FieldOffset(Offset = "0xE5")]
		private bool mShowingProcessBarMove;

		// Token: 0x04007908 RID: 30984
		[Token(Token = "0x4007908")]
		[FieldOffset(Offset = "0xE8")]
		private GameObject mMoveEffectObj;

		// Token: 0x04007909 RID: 30985
		[Token(Token = "0x4007909")]
		[FieldOffset(Offset = "0xF0")]
		private UIActivityActivenessController.SliderProcessingDelegate m_SliderProcessingDelete;

		// Token: 0x0400790A RID: 30986
		[Token(Token = "0x400790A")]
		[FieldOffset(Offset = "0xF8")]
		private List<UIActivityActivenessRewardDescription> m_ReceivableActivenessReward;

		// Token: 0x020013D7 RID: 5079
		// (Invoke) Token: 0x06005356 RID: 21334
		[Token(Token = "0x20013D7")]
		private delegate void SliderProcessingDelegate(uint activenessValue);

		// Token: 0x020013D8 RID: 5080
		[Token(Token = "0x20013D8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EC0A8", Offset = "0x10EC0A8")]
		private sealed class <>c__DisplayClass42_0
		{
			// Token: 0x06005359 RID: 21337 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005359")]
			[Address(RVA = "0x1A427F4", Offset = "0x1A427F4", VA = "0x7BBC2427F4")]
			public <>c__DisplayClass42_0()
			{
			}

			// Token: 0x0600535A RID: 21338 RVA: 0x00018E70 File Offset: 0x00017070
			[Token(Token = "0x600535A")]
			[Address(RVA = "0x1A43530", Offset = "0x1A43530", VA = "0x7BBC243530")]
			internal bool <OnActivenessChanged>b__0(UIActivityActivenessRewardDescription e)
			{
				return default(bool);
			}

			// Token: 0x0600535B RID: 21339 RVA: 0x00018E88 File Offset: 0x00017088
			[Token(Token = "0x600535B")]
			[Address(RVA = "0x1A435CC", Offset = "0x1A435CC", VA = "0x7BBC2435CC")]
			internal bool <OnActivenessChanged>b__1(UIActivityActivenessItemController e)
			{
				return default(bool);
			}

			// Token: 0x0400790B RID: 30987
			[Token(Token = "0x400790B")]
			[FieldOffset(Offset = "0x10")]
			public UIActivityActivenessController <>4__this;

			// Token: 0x0400790C RID: 30988
			[Token(Token = "0x400790C")]
			[FieldOffset(Offset = "0x18")]
			public uint id;
		}
	}
}
