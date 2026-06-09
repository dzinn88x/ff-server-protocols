using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using Spine;
using Spine.Unity;
using UnityEngine;

namespace COW
{
	// Token: 0x0200138D RID: 5005
	[Token(Token = "0x200138D")]
	public class DiceGamePlayerController : UIBaseController
	{
		// Token: 0x060050AD RID: 20653 RVA: 0x00018780 File Offset: 0x00016980
		[Token(Token = "0x60050AD")]
		[Address(RVA = "0x1606B70", Offset = "0x1606B70", VA = "0x7BBBE06B70")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060050AE RID: 20654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050AE")]
		[Address(RVA = "0x1606BC0", Offset = "0x1606BC0", VA = "0x7BBBE06BC0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060050AF RID: 20655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050AF")]
		[Address(RVA = "0x16070D4", Offset = "0x16070D4", VA = "0x7BBBE070D4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060050B0 RID: 20656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050B0")]
		[Address(RVA = "0x1607268", Offset = "0x1607268", VA = "0x7BBBE07268")]
		private void OnSpineAnimationComplete(TrackEntry pTrackEntry)
		{
		}

		// Token: 0x060050B1 RID: 20657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050B1")]
		[Address(RVA = "0x1606FDC", Offset = "0x1606FDC", VA = "0x7BBBE06FDC")]
		public void SetSpineAnim(ESpineAnimType t, bool highPri = false, bool loop = true)
		{
		}

		// Token: 0x060050B2 RID: 20658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050B2")]
		[Address(RVA = "0x160726C", Offset = "0x160726C", VA = "0x7BBBE0726C")]
		public void SetWayPoint(List<UIDiceGameGridItemController> gridItems, List<UIDiceGameGridWayPoint> wayPoints)
		{
		}

		// Token: 0x060050B3 RID: 20659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050B3")]
		[Address(RVA = "0x16072E4", Offset = "0x16072E4", VA = "0x7BBBE072E4")]
		public void SetAnimInfo(Transform tokenTran, Transform diceTran)
		{
		}

		// Token: 0x060050B4 RID: 20660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050B4")]
		[Address(RVA = "0x1607594", Offset = "0x1607594", VA = "0x7BBBE07594")]
		public void SetCurrentGridIAmIn(UIDiceGameGridItemController gridItem)
		{
		}

		// Token: 0x060050B5 RID: 20661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050B5")]
		[Address(RVA = "0x1607864", Offset = "0x1607864", VA = "0x7BBBE07864")]
		public UIDiceGameGridItemController GetCurrentGridIAmIn()
		{
			return null;
		}

		// Token: 0x060050B6 RID: 20662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050B6")]
		[Address(RVA = "0x160786C", Offset = "0x160786C", VA = "0x7BBBE0786C")]
		public void SetPhaseView(uint phaseNum)
		{
		}

		// Token: 0x060050B7 RID: 20663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050B7")]
		[Address(RVA = "0x1607AF0", Offset = "0x1607AF0", VA = "0x7BBBE07AF0")]
		public void PlayPhaseChangeAnim()
		{
		}

		// Token: 0x060050B8 RID: 20664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050B8")]
		[Address(RVA = "0x1607BE8", Offset = "0x1607BE8", VA = "0x7BBBE07BE8")]
		private void _MoveOneCell(int delStep)
		{
		}

		// Token: 0x060050B9 RID: 20665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050B9")]
		[Address(RVA = "0x1608088", Offset = "0x1608088", VA = "0x7BBBE08088")]
		public void Move(int moveNums)
		{
		}

		// Token: 0x060050BA RID: 20666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050BA")]
		[Address(RVA = "0x16080B0", Offset = "0x16080B0", VA = "0x7BBBE080B0")]
		private void OnMoveOneCellEnd()
		{
		}

		// Token: 0x060050BB RID: 20667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050BB")]
		[Address(RVA = "0x1607F58", Offset = "0x1607F58", VA = "0x7BBBE07F58")]
		private void MoveFinished()
		{
		}

		// Token: 0x060050BC RID: 20668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050BC")]
		[Address(RVA = "0x1608328", Offset = "0x1608328", VA = "0x7BBBE08328")]
		private void TryContinueMove(params object[] data)
		{
		}

		// Token: 0x060050BD RID: 20669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050BD")]
		[Address(RVA = "0x160833C", Offset = "0x160833C", VA = "0x7BBBE0833C")]
		public void UpdateBuffView()
		{
		}

		// Token: 0x060050BE RID: 20670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050BE")]
		[Address(RVA = "0x16076D4", Offset = "0x16076D4", VA = "0x7BBBE076D4")]
		private void FlipCharacter(int index)
		{
		}

		// Token: 0x060050BF RID: 20671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050BF")]
		[Address(RVA = "0x160815C", Offset = "0x160815C", VA = "0x7BBBE0815C")]
		private void PlayMoveEndEffect()
		{
		}

		// Token: 0x060050C0 RID: 20672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050C0")]
		[Address(RVA = "0x1607DBC", Offset = "0x1607DBC", VA = "0x7BBBE07DBC")]
		private void PlayTrailEffect(int delStep)
		{
		}

		// Token: 0x060050C1 RID: 20673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050C1")]
		[Address(RVA = "0x16083CC", Offset = "0x16083CC", VA = "0x7BBBE083CC")]
		public void ShowAnimation(EDiceGamePlayerAnimationType t, uint val = 0U, string info = "")
		{
		}

		// Token: 0x060050C2 RID: 20674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050C2")]
		[Address(RVA = "0x1608818", Offset = "0x1608818", VA = "0x7BBBE08818")]
		public DiceGamePlayerController()
		{
		}

		// Token: 0x060050C3 RID: 20675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050C3")]
		[Address(RVA = "0x1608A08", Offset = "0x1608A08", VA = "0x7BBBE08A08")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DFFC", Offset = "0x113DFFC")]
		private void <PlayPhaseChangeAnim>b__32_0()
		{
		}

		// Token: 0x0400772C RID: 30508
		[Token(Token = "0x400772C")]
		[FieldOffset(Offset = "0x58")]
		private SkeletonAnimation m_SkeletioAnim;

		// Token: 0x0400772D RID: 30509
		[Token(Token = "0x400772D")]
		private const int movementTrack = 0;

		// Token: 0x0400772E RID: 30510
		[Token(Token = "0x400772E")]
		private const int actionTrack = 1;

		// Token: 0x0400772F RID: 30511
		[Token(Token = "0x400772F")]
		private const string idleAnim = "Idle";

		// Token: 0x04007730 RID: 30512
		[Token(Token = "0x4007730")]
		private const string walkAnim = "walk";

		// Token: 0x04007731 RID: 30513
		[Token(Token = "0x4007731")]
		[FieldOffset(Offset = "0x60")]
		private List<UIDiceGameGridItemController> m_GridItems;

		// Token: 0x04007732 RID: 30514
		[Token(Token = "0x4007732")]
		[FieldOffset(Offset = "0x68")]
		private List<UIDiceGameGridWayPoint> m_WayPoints;

		// Token: 0x04007733 RID: 30515
		[Token(Token = "0x4007733")]
		[FieldOffset(Offset = "0x70")]
		private UIDiceGameGridItemController m_GridItemIAmIn;

		// Token: 0x04007734 RID: 30516
		[Token(Token = "0x4007734")]
		[FieldOffset(Offset = "0x78")]
		private Dictionary<uint, ResourceID> m_PlayerPhaseTxtureMap;

		// Token: 0x04007735 RID: 30517
		[Token(Token = "0x4007735")]
		[FieldOffset(Offset = "0x80")]
		private uint m_PlayerCurPhase;

		// Token: 0x04007736 RID: 30518
		[Token(Token = "0x4007736")]
		[FieldOffset(Offset = "0x88")]
		private UIModelMVP m_ModelMVP;

		// Token: 0x04007737 RID: 30519
		[Token(Token = "0x4007737")]
		[FieldOffset(Offset = "0x90")]
		private int m_DeltaStep;

		// Token: 0x04007738 RID: 30520
		[Token(Token = "0x4007738")]
		[FieldOffset(Offset = "0x94")]
		private int m_DeltaStepAfterStartPoint;

		// Token: 0x04007739 RID: 30521
		[Token(Token = "0x4007739")]
		[FieldOffset(Offset = "0x98")]
		private int m_CurrentWayPointIndex;

		// Token: 0x0400773A RID: 30522
		[Token(Token = "0x400773A")]
		[FieldOffset(Offset = "0x9C")]
		private int m_MaxWayLength;

		// Token: 0x0400773B RID: 30523
		[Token(Token = "0x400773B")]
		[FieldOffset(Offset = "0xA0")]
		private Vector3 tokenSprPos;

		// Token: 0x0400773C RID: 30524
		[Token(Token = "0x400773C")]
		[FieldOffset(Offset = "0xAC")]
		private Vector3 diceSprPos;

		// Token: 0x0400773D RID: 30525
		[Token(Token = "0x400773D")]
		[FieldOffset(Offset = "0xB8")]
		private float m_SpineScaleX;

		// Token: 0x0400773E RID: 30526
		[Token(Token = "0x400773E")]
		[FieldOffset(Offset = "0xC0")]
		private TweenPosition m_TweenPos;

		// Token: 0x0400773F RID: 30527
		[Token(Token = "0x400773F")]
		[FieldOffset(Offset = "0xC8")]
		private UIDiceGamePlayerView m_View;

		// Token: 0x04007740 RID: 30528
		[Token(Token = "0x4007740")]
		[FieldOffset(Offset = "0xD0")]
		private Dictionary<uint, ResourceID> m_MoveAudioMap;

		// Token: 0x04007741 RID: 30529
		[Token(Token = "0x4007741")]
		[FieldOffset(Offset = "0xD8")]
		private uint m_AnimDelayCallID;

		// Token: 0x04007742 RID: 30530
		[Token(Token = "0x4007742")]
		[FieldOffset(Offset = "0xDC")]
		private uint m_CacheStep;

		// Token: 0x04007743 RID: 30531
		[Token(Token = "0x4007743")]
		[FieldOffset(Offset = "0xE0")]
		private ResourceID m_CacheAudioRes;
	}
}
