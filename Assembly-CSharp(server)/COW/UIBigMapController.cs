using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using Lean.Touch;
using UnityEngine;

namespace COW
{
	// Token: 0x020016EA RID: 5866
	[Token(Token = "0x20016EA")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F1034", Offset = "0x10F1034")]
	internal class UIBigMapController : UIMapBaseController
	{
		// Token: 0x06006C80 RID: 27776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C80")]
		[Address(RVA = "0x1429200", Offset = "0x1429200", VA = "0x7BBBC29200")]
		public List<Vector3> getMapMarks()
		{
			return null;
		}

		// Token: 0x06006C81 RID: 27777 RVA: 0x0001EA50 File Offset: 0x0001CC50
		[Token(Token = "0x6006C81")]
		[Address(RVA = "0x1429208", Offset = "0x1429208", VA = "0x7BBBC29208")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006C82 RID: 27778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C82")]
		[Address(RVA = "0x1429258", Offset = "0x1429258", VA = "0x7BBBC29258", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006C83 RID: 27779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C83")]
		[Address(RVA = "0x1429CBC", Offset = "0x1429CBC", VA = "0x7BBBC29CBC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006C84 RID: 27780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C84")]
		[Address(RVA = "0x1429808", Offset = "0x1429808", VA = "0x7BBBC29808")]
		private void InitUIParams()
		{
		}

		// Token: 0x06006C85 RID: 27781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C85")]
		[Address(RVA = "0x1429854", Offset = "0x1429854", VA = "0x7BBBC29854")]
		private void InitUIElements()
		{
		}

		// Token: 0x06006C86 RID: 27782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C86")]
		[Address(RVA = "0x142A3F4", Offset = "0x142A3F4", VA = "0x7BBBC2A3F4", Slot = "28")]
		protected override void RegisterEvents()
		{
		}

		// Token: 0x06006C87 RID: 27783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C87")]
		[Address(RVA = "0x142A760", Offset = "0x142A760", VA = "0x7BBBC2A760", Slot = "29")]
		protected override void UnRegisterEvents()
		{
		}

		// Token: 0x06006C88 RID: 27784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C88")]
		[Address(RVA = "0x142A0C8", Offset = "0x142A0C8", VA = "0x7BBBC2A0C8")]
		private void ShowRankingGameTips()
		{
		}

		// Token: 0x06006C89 RID: 27785 RVA: 0x0001EA68 File Offset: 0x0001CC68
		[Token(Token = "0x6006C89")]
		[Address(RVA = "0x142AACC", Offset = "0x142AACC", VA = "0x7BBBC2AACC")]
		private bool OnEscapeClick()
		{
			return default(bool);
		}

		// Token: 0x06006C8A RID: 27786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C8A")]
		[Address(RVA = "0x142AAF8", Offset = "0x142AAF8", VA = "0x7BBBC2AAF8")]
		private void OnBtnCloseClick()
		{
		}

		// Token: 0x06006C8B RID: 27787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C8B")]
		[Address(RVA = "0x142AD14", Offset = "0x142AD14", VA = "0x7BBBC2AD14", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06006C8C RID: 27788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C8C")]
		[Address(RVA = "0x142AF20", Offset = "0x142AF20", VA = "0x7BBBC2AF20")]
		private void OnBtnRevive()
		{
		}

		// Token: 0x06006C8D RID: 27789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C8D")]
		[Address(RVA = "0x142B518", Offset = "0x142B518", VA = "0x7BBBC2B518")]
		private void OnBtnQuitRevive()
		{
		}

		// Token: 0x06006C8E RID: 27790 RVA: 0x0001EA80 File Offset: 0x0001CC80
		[Token(Token = "0x6006C8E")]
		[Address(RVA = "0x142B234", Offset = "0x142B234", VA = "0x7BBBC2B234")]
		private bool IsOutsideSafeZone(Vector3 pos, bool project)
		{
			return default(bool);
		}

		// Token: 0x06006C8F RID: 27791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C8F")]
		[Address(RVA = "0x142B3A4", Offset = "0x142B3A4", VA = "0x7BBBC2B3A4")]
		private void WarnInvalidRevivePos()
		{
		}

		// Token: 0x06006C90 RID: 27792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C90")]
		[Address(RVA = "0x142B624", Offset = "0x142B624", VA = "0x7BBBC2B624")]
		private void OnCountDownFinished()
		{
		}

		// Token: 0x06006C91 RID: 27793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C91")]
		[Address(RVA = "0x1429E10", Offset = "0x1429E10", VA = "0x7BBBC29E10")]
		private void StopReviveCoundDownSound()
		{
		}

		// Token: 0x06006C92 RID: 27794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C92")]
		[Address(RVA = "0x142B854", Offset = "0x142B854", VA = "0x7BBBC2B854", Slot = "33")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x06006C93 RID: 27795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C93")]
		[Address(RVA = "0x142BB90", Offset = "0x142BB90", VA = "0x7BBBC2BB90", Slot = "34")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x06006C94 RID: 27796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C94")]
		[Address(RVA = "0x142BF24", Offset = "0x142BF24", VA = "0x7BBBC2BF24")]
		private void OnAddLocalPlayer(params object[] param)
		{
		}

		// Token: 0x06006C95 RID: 27797 RVA: 0x0001EA98 File Offset: 0x0001CC98
		[Token(Token = "0x6006C95")]
		[Address(RVA = "0x142BF90", Offset = "0x142BF90", VA = "0x7BBBC2BF90")]
		public bool AddMarkOnMap(LeanFinger finger, bool checkWithinSafeZone)
		{
			return default(bool);
		}

		// Token: 0x06006C96 RID: 27798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C96")]
		[Address(RVA = "0x142C390", Offset = "0x142C390", VA = "0x7BBBC2C390")]
		private void UpdateLocalMark(Vector3 p)
		{
		}

		// Token: 0x06006C97 RID: 27799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C97")]
		[Address(RVA = "0x142C4A0", Offset = "0x142C4A0", VA = "0x7BBBC2C4A0")]
		public void RemoveMarkOnMap()
		{
		}

		// Token: 0x06006C98 RID: 27800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C98")]
		[Address(RVA = "0x142C51C", Offset = "0x142C51C", VA = "0x7BBBC2C51C", Slot = "32")]
		protected override void OnPlayerHPChanged(params object[] data)
		{
		}

		// Token: 0x06006C99 RID: 27801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C99")]
		[Address(RVA = "0x142C554", Offset = "0x142C554", VA = "0x7BBBC2C554")]
		public void SyncTeammateMapMark(params object[] data)
		{
		}

		// Token: 0x06006C9A RID: 27802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C9A")]
		[Address(RVA = "0x142C78C", Offset = "0x142C78C", VA = "0x7BBBC2C78C")]
		private void OnTeamInfoGet(params object[] data)
		{
		}

		// Token: 0x06006C9B RID: 27803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C9B")]
		[Address(RVA = "0x142CB58", Offset = "0x142CB58", VA = "0x7BBBC2CB58")]
		private void SyncTeamateState(params object[] data)
		{
		}

		// Token: 0x06006C9C RID: 27804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C9C")]
		[Address(RVA = "0x142CB90", Offset = "0x142CB90", VA = "0x7BBBC2CB90")]
		private void SendMapMarkChanged(Vector2 screenPos, bool isDel)
		{
		}

		// Token: 0x06006C9D RID: 27805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C9D")]
		[Address(RVA = "0x142CE90", Offset = "0x142CE90", VA = "0x7BBBC2CE90")]
		public void OnTap(LeanFinger finger)
		{
		}

		// Token: 0x06006C9E RID: 27806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C9E")]
		[Address(RVA = "0x142D2E0", Offset = "0x142D2E0", VA = "0x7BBBC2D2E0")]
		public void OnGesture(List<LeanFinger> fingers)
		{
		}

		// Token: 0x06006C9F RID: 27807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C9F")]
		[Address(RVA = "0x142D654", Offset = "0x142D654", VA = "0x7BBBC2D654")]
		private void FingerSet(LeanFinger finger)
		{
		}

		// Token: 0x06006CA0 RID: 27808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CA0")]
		[Address(RVA = "0x142D7A4", Offset = "0x142D7A4", VA = "0x7BBBC2D7A4")]
		private void FingerDown(LeanFinger finger)
		{
		}

		// Token: 0x06006CA1 RID: 27809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CA1")]
		[Address(RVA = "0x142D810", Offset = "0x142D810", VA = "0x7BBBC2D810")]
		private void OnEnableBigMap(params object[] param)
		{
		}

		// Token: 0x06006CA2 RID: 27810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CA2")]
		[Address(RVA = "0x1429EBC", Offset = "0x1429EBC", VA = "0x7BBBC29EBC")]
		private void UpdateUIForMapMode()
		{
		}

		// Token: 0x06006CA3 RID: 27811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CA3")]
		[Address(RVA = "0x142E1A0", Offset = "0x142E1A0", VA = "0x7BBBC2E1A0")]
		private List<nS}etYj> GetUsingWeaponsList(List<int> unUsedList)
		{
			return null;
		}

		// Token: 0x06006CA4 RID: 27812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CA4")]
		[Address(RVA = "0x142E4B0", Offset = "0x142E4B0", VA = "0x7BBBC2E4B0")]
		private void UpdateUIForCurrentAttachments(params object[] param)
		{
		}

		// Token: 0x06006CA5 RID: 27813 RVA: 0x0001EAB0 File Offset: 0x0001CCB0
		[Token(Token = "0x6006CA5")]
		[Address(RVA = "0x142C0F0", Offset = "0x142C0F0", VA = "0x7BBBC2C0F0")]
		private bool IsMapTouched(Vector2 pos)
		{
			return default(bool);
		}

		// Token: 0x06006CA6 RID: 27814 RVA: 0x0001EAC8 File Offset: 0x0001CCC8
		[Token(Token = "0x6006CA6")]
		[Address(RVA = "0x142C138", Offset = "0x142C138", VA = "0x7BBBC2C138")]
		private Vector3 ScreenToLocalPosition(Vector2 pos)
		{
			return default(Vector3);
		}

		// Token: 0x06006CA7 RID: 27815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CA7")]
		[Address(RVA = "0x142E93C", Offset = "0x142E93C", VA = "0x7BBBC2E93C")]
		private void Update()
		{
		}

		// Token: 0x06006CA8 RID: 27816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CA8")]
		[Address(RVA = "0x142EA40", Offset = "0x142EA40", VA = "0x7BBBC2EA40")]
		private void UpdateHPEP()
		{
		}

		// Token: 0x06006CA9 RID: 27817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CA9")]
		[Address(RVA = "0x142EE74", Offset = "0x142EE74", VA = "0x7BBBC2EE74", Slot = "30")]
		protected override void OnObservePlayer(params object[] data)
		{
		}

		// Token: 0x06006CAA RID: 27818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CAA")]
		[Address(RVA = "0x142EFD8", Offset = "0x142EFD8", VA = "0x7BBBC2EFD8")]
		private void OnJumpActionEnter(params object[] data)
		{
		}

		// Token: 0x06006CAB RID: 27819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CAB")]
		[Address(RVA = "0x142F0D4", Offset = "0x142F0D4", VA = "0x7BBBC2F0D4")]
		private void OnJumpActionEnd(params object[] data)
		{
		}

		// Token: 0x06006CAC RID: 27820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CAC")]
		[Address(RVA = "0x142F118", Offset = "0x142F118", VA = "0x7BBBC2F118")]
		private void OnMatchEnd(params object[] data)
		{
		}

		// Token: 0x06006CAD RID: 27821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CAD")]
		[Address(RVA = "0x142F1B4", Offset = "0x142F1B4", VA = "0x7BBBC2F1B4")]
		public void ActiveWereWolvesTip(bool isWolf)
		{
		}

		// Token: 0x06006CAE RID: 27822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CAE")]
		[Address(RVA = "0x142F23C", Offset = "0x142F23C", VA = "0x7BBBC2F23C")]
		public UIBigMapController()
		{
		}

		// Token: 0x06006CAF RID: 27823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CAF")]
		[Address(RVA = "0x142F328", Offset = "0x142F328", VA = "0x7BBBC2F328")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11412CC", Offset = "0x11412CC")]
		private void <OnVisibilityChanged>b__35_0()
		{
		}

		// Token: 0x0400881D RID: 34845
		[Token(Token = "0x400881D")]
		[FieldOffset(Offset = "0x60")]
		private UIBigMapViewExt m_View;

		// Token: 0x0400881E RID: 34846
		[Token(Token = "0x400881E")]
		[FieldOffset(Offset = "0x68")]
		private Player m_Player;

		// Token: 0x0400881F RID: 34847
		[Token(Token = "0x400881F")]
		[FieldOffset(Offset = "0x70")]
		private AudioResource m_ReviveCountDownAudio;

		// Token: 0x04008820 RID: 34848
		[Token(Token = "0x4008820")]
		[FieldOffset(Offset = "0x78")]
		public float SIZE_BIGMAP_X;

		// Token: 0x04008821 RID: 34849
		[Token(Token = "0x4008821")]
		[FieldOffset(Offset = "0x7C")]
		public float SIZE_BIGMAP_Y;

		// Token: 0x04008822 RID: 34850
		[Token(Token = "0x4008822")]
		[FieldOffset(Offset = "0x80")]
		private float ScreenHeight;

		// Token: 0x04008823 RID: 34851
		[Token(Token = "0x4008823")]
		[FieldOffset(Offset = "0x84")]
		private float ScreenWidth;

		// Token: 0x04008824 RID: 34852
		[Token(Token = "0x4008824")]
		[FieldOffset(Offset = "0x88")]
		private Vector2 m_MapCenterScreenPosition;

		// Token: 0x04008825 RID: 34853
		[Token(Token = "0x4008825")]
		private const float MAX_MAP_SCALE = 4f;

		// Token: 0x04008826 RID: 34854
		[Token(Token = "0x4008826")]
		[FieldOffset(Offset = "0x90")]
		private float m_MaxMapScale;

		// Token: 0x04008827 RID: 34855
		[Token(Token = "0x4008827")]
		[FieldOffset(Offset = "0x94")]
		[Attribute(Name = "RangeAttribute", RVA = "0x112F85C", Offset = "0x112F85C")]
		public float WheelSensitivity;

		// Token: 0x04008828 RID: 34856
		[Token(Token = "0x4008828")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x112F874", Offset = "0x112F874")]
		public Camera Camera;

		// Token: 0x04008829 RID: 34857
		[Token(Token = "0x4008829")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x112F8AC", Offset = "0x112F8AC")]
		public float Target;

		// Token: 0x0400882A RID: 34858
		[Token(Token = "0x400882A")]
		[FieldOffset(Offset = "0xA4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x112F8E4", Offset = "0x112F8E4")]
		public float Minimum;

		// Token: 0x0400882B RID: 34859
		[Token(Token = "0x400882B")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x112F91C", Offset = "0x112F91C")]
		public float Maximum;

		// Token: 0x0400882C RID: 34860
		[Token(Token = "0x400882C")]
		[FieldOffset(Offset = "0xAC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x112F954", Offset = "0x112F954")]
		public float Dampening;

		// Token: 0x0400882D RID: 34861
		[Token(Token = "0x400882D")]
		[FieldOffset(Offset = "0xB0")]
		private List<Vector3> m_MapMarkList;

		// Token: 0x0400882E RID: 34862
		[Token(Token = "0x400882E")]
		[FieldOffset(Offset = "0xB8")]
		private Vector2 m_LastTouchPos;

		// Token: 0x0400882F RID: 34863
		[Token(Token = "0x400882F")]
		[FieldOffset(Offset = "0xC0")]
		private EBigMapType m_MapType;

		// Token: 0x04008830 RID: 34864
		[Token(Token = "0x4008830")]
		[FieldOffset(Offset = "0xC4")]
		private bool m_ShowedHotzoneHint;

		// Token: 0x04008831 RID: 34865
		[Token(Token = "0x4008831")]
		[FieldOffset(Offset = "0xC5")]
		private bool m_IsCatapultIconInited;

		// Token: 0x04008832 RID: 34866
		[Token(Token = "0x4008832")]
		[FieldOffset(Offset = "0xC6")]
		private bool DEBUG_CATAPULT_ON;

		// Token: 0x04008833 RID: 34867
		[Token(Token = "0x4008833")]
		[FieldOffset(Offset = "0xC8")]
		private UIHudPopupController m_HotzoneHintCtrl;

		// Token: 0x04008834 RID: 34868
		[Token(Token = "0x4008834")]
		[FieldOffset(Offset = "0xD0")]
		private Vector3 m_OrignalRebornMapEffectScale;
	}
}
