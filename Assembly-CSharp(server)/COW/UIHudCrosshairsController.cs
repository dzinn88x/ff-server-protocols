using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200189A RID: 6298
	[Token(Token = "0x200189A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F4764", Offset = "0x10F4764")]
	internal class UIHudCrosshairsController : UIBaseController
	{
		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x06007CDB RID: 31963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700098D")]
		public GameObject BuildingCrossHair
		{
			[Token(Token = "0x6007CDB")]
			[Address(RVA = "0x1A96F7C", Offset = "0x1A96F7C", VA = "0x7BBC296F7C")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x06007CDC RID: 31964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700098E")]
		public BoxCollider[] BuildingCrossHairColliders
		{
			[Token(Token = "0x6007CDC")]
			[Address(RVA = "0x1A96F84", Offset = "0x1A96F84", VA = "0x7BBC296F84")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007CDD RID: 31965 RVA: 0x000224B8 File Offset: 0x000206B8
		[Token(Token = "0x6007CDD")]
		[Address(RVA = "0x1A96F8C", Offset = "0x1A96F8C", VA = "0x7BBC296F8C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007CDE RID: 31966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CDE")]
		[Address(RVA = "0x1A96FDC", Offset = "0x1A96FDC", VA = "0x7BBC296FDC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007CDF RID: 31967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CDF")]
		[Address(RVA = "0x1A97CB4", Offset = "0x1A97CB4", VA = "0x7BBC297CB4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007CE0 RID: 31968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CE0")]
		[Address(RVA = "0x1A9841C", Offset = "0x1A9841C", VA = "0x7BBC29841C")]
		private void FrameTick()
		{
		}

		// Token: 0x06007CE1 RID: 31969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CE1")]
		[Address(RVA = "0x1A9B354", Offset = "0x1A9B354", VA = "0x7BBC29B354")]
		private void Update()
		{
		}

		// Token: 0x06007CE2 RID: 31970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CE2")]
		[Address(RVA = "0x1A9B358", Offset = "0x1A9B358", VA = "0x7BBC29B358", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06007CE3 RID: 31971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CE3")]
		[Address(RVA = "0x1A9AB84", Offset = "0x1A9AB84", VA = "0x7BBC29AB84")]
		private void UpdateScaleTween()
		{
		}

		// Token: 0x06007CE4 RID: 31972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CE4")]
		[Address(RVA = "0x1A9AE14", Offset = "0x1A9AE14", VA = "0x7BBC29AE14")]
		private void UpdatePositionTween()
		{
		}

		// Token: 0x06007CE5 RID: 31973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CE5")]
		[Address(RVA = "0x1A9B08C", Offset = "0x1A9B08C", VA = "0x7BBC29B08C")]
		private void UpdateRotationTween()
		{
		}

		// Token: 0x06007CE6 RID: 31974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CE6")]
		[Address(RVA = "0x1A9B45C", Offset = "0x1A9B45C", VA = "0x7BBC29B45C")]
		private void OnSightingStateChanged(params object[] data)
		{
		}

		// Token: 0x06007CE7 RID: 31975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CE7")]
		[Address(RVA = "0x1A9BFA4", Offset = "0x1A9BFA4", VA = "0x7BBC29BFA4")]
		private void OnSightingCharged(params object[] data)
		{
		}

		// Token: 0x06007CE8 RID: 31976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CE8")]
		[Address(RVA = "0x1A9C328", Offset = "0x1A9C328", VA = "0x7BBC29C328")]
		private void OnObserverSwitch(params object[] data)
		{
		}

		// Token: 0x06007CE9 RID: 31977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CE9")]
		[Address(RVA = "0x1A9C610", Offset = "0x1A9C610", VA = "0x7BBC29C610")]
		private void OnSightingFired(params object[] data)
		{
		}

		// Token: 0x06007CEA RID: 31978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CEA")]
		[Address(RVA = "0x1A9C8A0", Offset = "0x1A9C8A0", VA = "0x7BBC29C8A0")]
		private void StartScaleTween(GameObject InObject, float InStartScale1, float InEndScale1, float InDuration1, float InEndScale2, float InDuration2)
		{
		}

		// Token: 0x06007CEB RID: 31979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CEB")]
		[Address(RVA = "0x1A9BE94", Offset = "0x1A9BE94", VA = "0x7BBC29BE94")]
		private void StartScaleTween(GameObject target, float startScale, float endScale, float duration)
		{
		}

		// Token: 0x06007CEC RID: 31980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CEC")]
		[Address(RVA = "0x1A9CA8C", Offset = "0x1A9CA8C", VA = "0x7BBC29CA8C")]
		private void StartPositionTween(GameObject target, Vector3 startPosition, Vector3 endPosition, float duration)
		{
		}

		// Token: 0x06007CED RID: 31981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CED")]
		[Address(RVA = "0x1A9CC44", Offset = "0x1A9CC44", VA = "0x7BBC29CC44")]
		private void StartRotaionTween(GameObject target, Vector3 startRotation, Vector3 endRotation, float duration)
		{
		}

		// Token: 0x06007CEE RID: 31982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CEE")]
		[Address(RVA = "0x1A9CDEC", Offset = "0x1A9CDEC", VA = "0x7BBC29CDEC")]
		private void TurnOffSighting()
		{
		}

		// Token: 0x06007CEF RID: 31983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CEF")]
		[Address(RVA = "0x1A9CFB0", Offset = "0x1A9CFB0", VA = "0x7BBC29CFB0")]
		private void OnInventoryOpened(params object[] data)
		{
		}

		// Token: 0x06007CF0 RID: 31984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CF0")]
		[Address(RVA = "0x1A9CFB4", Offset = "0x1A9CFB4", VA = "0x7BBC29CFB4")]
		private void OnInventoryTryUseMedkit(params object[] data)
		{
		}

		// Token: 0x06007CF1 RID: 31985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CF1")]
		[Address(RVA = "0x1A9CFB8", Offset = "0x1A9CFB8", VA = "0x7BBC29CFB8")]
		private void OnInventoryTryUseRepairKit(params object[] data)
		{
		}

		// Token: 0x06007CF2 RID: 31986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CF2")]
		[Address(RVA = "0x1A9CFBC", Offset = "0x1A9CFBC", VA = "0x7BBC29CFBC")]
		private void OnLeaderboardOpened(params object[] data)
		{
		}

		// Token: 0x06007CF3 RID: 31987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CF3")]
		[Address(RVA = "0x1A9CFC0", Offset = "0x1A9CFC0", VA = "0x7BBC29CFC0")]
		private void OnFastRunningActivated(params object[] data)
		{
		}

		// Token: 0x06007CF4 RID: 31988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CF4")]
		[Address(RVA = "0x1A9CFC4", Offset = "0x1A9CFC4", VA = "0x7BBC29CFC4")]
		private void OnLocalPlayerHitOthers(params object[] data)
		{
		}

		// Token: 0x06007CF5 RID: 31989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CF5")]
		[Address(RVA = "0x1A9D368", Offset = "0x1A9D368", VA = "0x7BBC29D368")]
		private void OnLocalPlayerKillOthers(params object[] data)
		{
		}

		// Token: 0x06007CF6 RID: 31990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007CF6")]
		[Address(RVA = "0x1A9D59C", Offset = "0x1A9D59C", VA = "0x7BBC29D59C")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x114298C", Offset = "0x114298C")]
		private IEnumerator PlayHitEffect()
		{
			return null;
		}

		// Token: 0x06007CF7 RID: 31991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CF7")]
		[Address(RVA = "0x1A9D63C", Offset = "0x1A9D63C", VA = "0x7BBC29D63C")]
		private void OnUpdateAimTraceClosePos(params object[] data)
		{
		}

		// Token: 0x06007CF8 RID: 31992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CF8")]
		[Address(RVA = "0x1A9D914", Offset = "0x1A9D914", VA = "0x7BBC29D914")]
		private void OnIceWallCrossHairChange(params object[] data)
		{
		}

		// Token: 0x06007CF9 RID: 31993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CF9")]
		[Address(RVA = "0x1A9DE20", Offset = "0x1A9DE20", VA = "0x7BBC29DE20")]
		private void OnCustomCrossHairChange(params object[] data)
		{
		}

		// Token: 0x06007CFA RID: 31994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CFA")]
		[Address(RVA = "0x1A9E0B8", Offset = "0x1A9E0B8", VA = "0x7BBC29E0B8")]
		private void OnRedEnvelopeCrossHairChange(params object[] data)
		{
		}

		// Token: 0x06007CFB RID: 31995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CFB")]
		[Address(RVA = "0x1A9E3CC", Offset = "0x1A9E3CC", VA = "0x7BBC29E3CC")]
		private void OnMatchEnd(params object[] data)
		{
		}

		// Token: 0x06007CFC RID: 31996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CFC")]
		[Address(RVA = "0x1A9E4FC", Offset = "0x1A9E4FC", VA = "0x7BBC29E4FC")]
		private void OnShowFireBanned(params object[] data)
		{
		}

		// Token: 0x06007CFD RID: 31997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CFD")]
		[Address(RVA = "0x1A9E5B4", Offset = "0x1A9E5B4", VA = "0x7BBC29E5B4")]
		private void OnShieldGunShieldHide(params object[] data)
		{
		}

		// Token: 0x06007CFE RID: 31998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007CFE")]
		[Address(RVA = "0x1A9E7E0", Offset = "0x1A9E7E0", VA = "0x7BBC29E7E0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x11429F0", Offset = "0x11429F0")]
		private IEnumerator ShieldGunShieldBrokenHide()
		{
			return null;
		}

		// Token: 0x06007CFF RID: 31999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CFF")]
		[Address(RVA = "0x1A9E880", Offset = "0x1A9E880", VA = "0x7BBC29E880")]
		public UIHudCrosshairsController()
		{
		}

		// Token: 0x06007D01 RID: 32001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D01")]
		[Address(RVA = "0x1A9EB7C", Offset = "0x1A9EB7C", VA = "0x7BBC29EB7C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1142A54", Offset = "0x1142A54")]
		private void <OnLocalPlayerHitOthers>b__61_0()
		{
		}

		// Token: 0x06007D02 RID: 32002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D02")]
		[Address(RVA = "0x1A9EBCC", Offset = "0x1A9EBCC", VA = "0x7BBC29EBCC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1142A64", Offset = "0x1142A64")]
		private void <OnLocalPlayerHitOthers>b__61_1()
		{
		}

		// Token: 0x06007D03 RID: 32003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D03")]
		[Address(RVA = "0x1A9EC10", Offset = "0x1A9EC10", VA = "0x7BBC29EC10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1142A74", Offset = "0x1142A74")]
		private void <OnLocalPlayerKillOthers>b__62_0()
		{
		}

		// Token: 0x0400908C RID: 37004
		[Token(Token = "0x400908C")]
		private const uint VISIBILITY_STATE_NORMAL = 1U;

		// Token: 0x0400908D RID: 37005
		[Token(Token = "0x400908D")]
		private const uint VISIBILITY_STATE_HIT = 2U;

		// Token: 0x0400908E RID: 37006
		[Token(Token = "0x400908E")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color AIM_COLOR_NO_TARGET;

		// Token: 0x0400908F RID: 37007
		[Token(Token = "0x400908F")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Color AIM_COLOR_HAS_TARGET;

		// Token: 0x04009090 RID: 37008
		[Token(Token = "0x4009090")]
		[FieldOffset(Offset = "0x20")]
		private static readonly Color GUNSIGHTCENTER_COLOR_NO_TARGET;

		// Token: 0x04009091 RID: 37009
		[Token(Token = "0x4009091")]
		[FieldOffset(Offset = "0x30")]
		private static readonly Color GUNSIGHTCENTER_COLOR_HAS_TARGET;

		// Token: 0x04009092 RID: 37010
		[Token(Token = "0x4009092")]
		[FieldOffset(Offset = "0x40")]
		private static readonly Color GUNSIGHTCENTER_COLOR_THERMAL_HAS_TARGET;

		// Token: 0x04009093 RID: 37011
		[Token(Token = "0x4009093")]
		[FieldOffset(Offset = "0x58")]
		private UIHudCrosshairsView m_View;

		// Token: 0x04009094 RID: 37012
		[Token(Token = "0x4009094")]
		[FieldOffset(Offset = "0x60")]
		private BitArrayBoolean m_CrosshairVisibility;

		// Token: 0x04009095 RID: 37013
		[Token(Token = "0x4009095")]
		[FieldOffset(Offset = "0x68")]
		private bool m_LastSightingState;

		// Token: 0x04009096 RID: 37014
		[Token(Token = "0x4009096")]
		[FieldOffset(Offset = "0x6C")]
		private Vector3 defaultSize;

		// Token: 0x04009097 RID: 37015
		[Token(Token = "0x4009097")]
		[FieldOffset(Offset = "0x78")]
		private GameObject m_BuildingCrossHair;

		// Token: 0x04009098 RID: 37016
		[Token(Token = "0x4009098")]
		[FieldOffset(Offset = "0x80")]
		private BoxCollider[] m_BuildingCrossHairColliders;

		// Token: 0x04009099 RID: 37017
		[Token(Token = "0x4009099")]
		[FieldOffset(Offset = "0x88")]
		private SpawnObjectCrossHairTrigger m_BuildingCrossHairTrigger;

		// Token: 0x0400909A RID: 37018
		[Token(Token = "0x400909A")]
		[FieldOffset(Offset = "0x90")]
		private IceWallCrossHairTrigger[] m_IcewallTriggers;

		// Token: 0x0400909B RID: 37019
		[Token(Token = "0x400909B")]
		[FieldOffset(Offset = "0x98")]
		private float m_OriginAngle;

		// Token: 0x0400909C RID: 37020
		[Token(Token = "0x400909C")]
		[FieldOffset(Offset = "0x9C")]
		private Vector3 m_OriginPos;

		// Token: 0x0400909D RID: 37021
		[Token(Token = "0x400909D")]
		[FieldOffset(Offset = "0xA8")]
		private ResourceID m_BuildingCrossHairID;

		// Token: 0x0400909E RID: 37022
		[Token(Token = "0x400909E")]
		[FieldOffset(Offset = "0xAC")]
		private bool m_StartCharge;

		// Token: 0x0400909F RID: 37023
		[Token(Token = "0x400909F")]
		[FieldOffset(Offset = "0xB0")]
		private float m_ChargDuration;

		// Token: 0x040090A0 RID: 37024
		[Token(Token = "0x40090A0")]
		[FieldOffset(Offset = "0xB4")]
		private float m_WeaponMaxChargeTime;

		// Token: 0x040090A1 RID: 37025
		[Token(Token = "0x40090A1")]
		[FieldOffset(Offset = "0xB8")]
		private string m_IconAimSpriteName;

		// Token: 0x040090A2 RID: 37026
		[Token(Token = "0x40090A2")]
		[FieldOffset(Offset = "0xC0")]
		private string m_IconBanSpriteName;

		// Token: 0x040090A3 RID: 37027
		[Token(Token = "0x40090A3")]
		[FieldOffset(Offset = "0xC8")]
		private ResourceID m_CurrAimSpriteResId;

		// Token: 0x040090A4 RID: 37028
		[Token(Token = "0x40090A4")]
		[FieldOffset(Offset = "0xCC")]
		private uint m_HitHintDelayId;

		// Token: 0x040090A5 RID: 37029
		[Token(Token = "0x40090A5")]
		[FieldOffset(Offset = "0xD0")]
		private uint m_KillHintDelayId;

		// Token: 0x040090A6 RID: 37030
		[Token(Token = "0x40090A6")]
		[FieldOffset(Offset = "0xD4")]
		private uint m_FlashHintDelayId;

		// Token: 0x040090A7 RID: 37031
		[Token(Token = "0x40090A7")]
		[FieldOffset(Offset = "0xD8")]
		private float m_LastOverlapPlayerCheckTime;

		// Token: 0x040090A8 RID: 37032
		[Token(Token = "0x40090A8")]
		[FieldOffset(Offset = "0xE0")]
		private Queue<UIHudCrosshairsController.ScaleTweenSeq> m_QueueScaleTween;

		// Token: 0x040090A9 RID: 37033
		[Token(Token = "0x40090A9")]
		[FieldOffset(Offset = "0xE8")]
		private Queue<UIHudCrosshairsController.PositionTweenSeq> m_QueuePositionTween;

		// Token: 0x040090AA RID: 37034
		[Token(Token = "0x40090AA")]
		[FieldOffset(Offset = "0xF0")]
		private Queue<UIHudCrosshairsController.RotationTweenSeq> m_QueueRotationTween;

		// Token: 0x040090AB RID: 37035
		[Token(Token = "0x40090AB")]
		[FieldOffset(Offset = "0xF8")]
		private float m_LastIceWallChangedTime;

		// Token: 0x0200189B RID: 6299
		[Token(Token = "0x200189B")]
		private class ScaleTweenSeq
		{
			// Token: 0x06007D04 RID: 32004 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D04")]
			[Address(RVA = "0x1A9CA3C", Offset = "0x1A9CA3C", VA = "0x7BBC29CA3C")]
			public ScaleTweenSeq(GameObject target, float startScale, float endScale, float duration)
			{
			}

			// Token: 0x040090AC RID: 37036
			[Token(Token = "0x40090AC")]
			[FieldOffset(Offset = "0x10")]
			public float startScale;

			// Token: 0x040090AD RID: 37037
			[Token(Token = "0x40090AD")]
			[FieldOffset(Offset = "0x14")]
			public float endScale;

			// Token: 0x040090AE RID: 37038
			[Token(Token = "0x40090AE")]
			[FieldOffset(Offset = "0x18")]
			public float duration;

			// Token: 0x040090AF RID: 37039
			[Token(Token = "0x40090AF")]
			[FieldOffset(Offset = "0x1C")]
			public bool start;

			// Token: 0x040090B0 RID: 37040
			[Token(Token = "0x40090B0")]
			[FieldOffset(Offset = "0x1D")]
			public bool end;

			// Token: 0x040090B1 RID: 37041
			[Token(Token = "0x40090B1")]
			[FieldOffset(Offset = "0x20")]
			public float time;

			// Token: 0x040090B2 RID: 37042
			[Token(Token = "0x40090B2")]
			[FieldOffset(Offset = "0x28")]
			public GameObject target;
		}

		// Token: 0x0200189C RID: 6300
		[Token(Token = "0x200189C")]
		private class PositionTweenSeq
		{
			// Token: 0x06007D05 RID: 32005 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D05")]
			[Address(RVA = "0x1A9CBCC", Offset = "0x1A9CBCC", VA = "0x7BBC29CBCC")]
			public PositionTweenSeq(GameObject target, Vector3 startPosition, Vector3 endPosition, float duration)
			{
			}

			// Token: 0x040090B3 RID: 37043
			[Token(Token = "0x40090B3")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 startPosition;

			// Token: 0x040090B4 RID: 37044
			[Token(Token = "0x40090B4")]
			[FieldOffset(Offset = "0x1C")]
			public Vector3 endPosition;

			// Token: 0x040090B5 RID: 37045
			[Token(Token = "0x40090B5")]
			[FieldOffset(Offset = "0x28")]
			public float duration;

			// Token: 0x040090B6 RID: 37046
			[Token(Token = "0x40090B6")]
			[FieldOffset(Offset = "0x2C")]
			public bool start;

			// Token: 0x040090B7 RID: 37047
			[Token(Token = "0x40090B7")]
			[FieldOffset(Offset = "0x2D")]
			public bool end;

			// Token: 0x040090B8 RID: 37048
			[Token(Token = "0x40090B8")]
			[FieldOffset(Offset = "0x30")]
			public float time;

			// Token: 0x040090B9 RID: 37049
			[Token(Token = "0x40090B9")]
			[FieldOffset(Offset = "0x38")]
			public GameObject target;
		}

		// Token: 0x0200189D RID: 6301
		[Token(Token = "0x200189D")]
		private class RotationTweenSeq
		{
			// Token: 0x06007D06 RID: 32006 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D06")]
			[Address(RVA = "0x1A9CD74", Offset = "0x1A9CD74", VA = "0x7BBC29CD74")]
			public RotationTweenSeq(GameObject target, Vector3 startRotation, Vector3 endRotation, float duration)
			{
			}

			// Token: 0x040090BA RID: 37050
			[Token(Token = "0x40090BA")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 startRotation;

			// Token: 0x040090BB RID: 37051
			[Token(Token = "0x40090BB")]
			[FieldOffset(Offset = "0x1C")]
			public Vector3 endRotation;

			// Token: 0x040090BC RID: 37052
			[Token(Token = "0x40090BC")]
			[FieldOffset(Offset = "0x28")]
			public float duration;

			// Token: 0x040090BD RID: 37053
			[Token(Token = "0x40090BD")]
			[FieldOffset(Offset = "0x2C")]
			public bool start;

			// Token: 0x040090BE RID: 37054
			[Token(Token = "0x40090BE")]
			[FieldOffset(Offset = "0x2D")]
			public bool end;

			// Token: 0x040090BF RID: 37055
			[Token(Token = "0x40090BF")]
			[FieldOffset(Offset = "0x30")]
			public float tiem;

			// Token: 0x040090C0 RID: 37056
			[Token(Token = "0x40090C0")]
			[FieldOffset(Offset = "0x38")]
			public GameObject target;
		}

		// Token: 0x0200189E RID: 6302
		[Token(Token = "0x200189E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F479C", Offset = "0x10F479C")]
		private sealed class <PlayHitEffect>d__63 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06007D07 RID: 32007 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D07")]
			[Address(RVA = "0x1A9D610", Offset = "0x1A9D610", VA = "0x7BBC29D610")]
			[DebuggerHidden]
			public <PlayHitEffect>d__63(int <>1__state)
			{
			}

			// Token: 0x06007D08 RID: 32008 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D08")]
			[Address(RVA = "0x1A9EC60", Offset = "0x1A9EC60", VA = "0x7BBC29EC60", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06007D09 RID: 32009 RVA: 0x000224D0 File Offset: 0x000206D0
			[Token(Token = "0x6007D09")]
			[Address(RVA = "0x1A9EC64", Offset = "0x1A9EC64", VA = "0x7BBC29EC64", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700098F RID: 2447
			// (get) Token: 0x06007D0A RID: 32010 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700098F")]
			private object Current
			{
				[Token(Token = "0x6007D0A")]
				[Address(RVA = "0x1A9EDFC", Offset = "0x1A9EDFC", VA = "0x7BBC29EDFC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06007D0B RID: 32011 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D0B")]
			[Address(RVA = "0x1A9EE04", Offset = "0x1A9EE04", VA = "0x7BBC29EE04", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000990 RID: 2448
			// (get) Token: 0x06007D0C RID: 32012 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000990")]
			private object Current
			{
				[Token(Token = "0x6007D0C")]
				[Address(RVA = "0x1A9EE6C", Offset = "0x1A9EE6C", VA = "0x7BBC29EE6C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040090C1 RID: 37057
			[Token(Token = "0x40090C1")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040090C2 RID: 37058
			[Token(Token = "0x40090C2")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040090C3 RID: 37059
			[Token(Token = "0x40090C3")]
			[FieldOffset(Offset = "0x20")]
			public UIHudCrosshairsController <>4__this;
		}

		// Token: 0x0200189F RID: 6303
		[Token(Token = "0x200189F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F47AC", Offset = "0x10F47AC")]
		private sealed class <ShieldGunShieldBrokenHide>d__72 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06007D0D RID: 32013 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D0D")]
			[Address(RVA = "0x1A9E854", Offset = "0x1A9E854", VA = "0x7BBC29E854")]
			[DebuggerHidden]
			public <ShieldGunShieldBrokenHide>d__72(int <>1__state)
			{
			}

			// Token: 0x06007D0E RID: 32014 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D0E")]
			[Address(RVA = "0x1A9EE74", Offset = "0x1A9EE74", VA = "0x7BBC29EE74", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06007D0F RID: 32015 RVA: 0x000224E8 File Offset: 0x000206E8
			[Token(Token = "0x6007D0F")]
			[Address(RVA = "0x1A9EE78", Offset = "0x1A9EE78", VA = "0x7BBC29EE78", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000991 RID: 2449
			// (get) Token: 0x06007D10 RID: 32016 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000991")]
			private object Current
			{
				[Token(Token = "0x6007D10")]
				[Address(RVA = "0x1A9EF28", Offset = "0x1A9EF28", VA = "0x7BBC29EF28", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06007D11 RID: 32017 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D11")]
			[Address(RVA = "0x1A9EF30", Offset = "0x1A9EF30", VA = "0x7BBC29EF30", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000992 RID: 2450
			// (get) Token: 0x06007D12 RID: 32018 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000992")]
			private object Current
			{
				[Token(Token = "0x6007D12")]
				[Address(RVA = "0x1A9EF98", Offset = "0x1A9EF98", VA = "0x7BBC29EF98", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040090C4 RID: 37060
			[Token(Token = "0x40090C4")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040090C5 RID: 37061
			[Token(Token = "0x40090C5")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040090C6 RID: 37062
			[Token(Token = "0x40090C6")]
			[FieldOffset(Offset = "0x20")]
			public UIHudCrosshairsController <>4__this;
		}
	}
}
