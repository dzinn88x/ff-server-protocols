using System;
using System.Collections.Generic;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001C55 RID: 7253
	[Token(Token = "0x2001C55")]
	public class DetectorMapObjectModel
	{
		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x06009DD4 RID: 40404 RVA: 0x000294A8 File Offset: 0x000276A8
		[Token(Token = "0x17000A69")]
		public Vector3 DetectorPosition
		{
			[Token(Token = "0x6009DD4")]
			[Address(RVA = "0x16032F8", Offset = "0x16032F8", VA = "0x7BBBE032F8")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x06009DD5 RID: 40405 RVA: 0x000294C0 File Offset: 0x000276C0
		// (set) Token: 0x06009DD6 RID: 40406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A6A")]
		public bool Stopped
		{
			[Token(Token = "0x6009DD5")]
			[Address(RVA = "0x16017E4", Offset = "0x16017E4", VA = "0x7BBBE017E4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114545C", Offset = "0x114545C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6009DD6")]
			[Address(RVA = "0x1604648", Offset = "0x1604648", VA = "0x7BBBE04648")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114546C", Offset = "0x114546C")]
			protected set
			{
			}
		}

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x06009DD7 RID: 40407 RVA: 0x000294D8 File Offset: 0x000276D8
		[Token(Token = "0x17000A6B")]
		public float Range
		{
			[Token(Token = "0x6009DD7")]
			[Address(RVA = "0x1601E98", Offset = "0x1601E98", VA = "0x7BBBE01E98")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06009DD8 RID: 40408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DD8")]
		[Address(RVA = "0x1604654", Offset = "0x1604654", VA = "0x7BBBE04654")]
		private DetectorMapObjectModel()
		{
		}

		// Token: 0x06009DD9 RID: 40409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009DD9")]
		[Address(RVA = "0x1601C7C", Offset = "0x1601C7C", VA = "0x7BBBE01C7C")]
		public static DetectorMapObjectModel GetModel()
		{
			return null;
		}

		// Token: 0x06009DDA RID: 40410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DDA")]
		[Address(RVA = "0x160295C", Offset = "0x160295C", VA = "0x7BBBE0295C")]
		public void Release()
		{
		}

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x06009DDB RID: 40411 RVA: 0x000294F0 File Offset: 0x000276F0
		[Token(Token = "0x17000A6C")]
		public bool Inited
		{
			[Token(Token = "0x6009DDB")]
			[Address(RVA = "0x1601D34", Offset = "0x1601D34", VA = "0x7BBBE01D34")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06009DDC RID: 40412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DDC")]
		[Address(RVA = "0x1601D44", Offset = "0x1601D44", VA = "0x7BBBE01D44")]
		internal void Init(]XMFBq\u0081 d, float fadeTime)
		{
		}

		// Token: 0x06009DDD RID: 40413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DDD")]
		[Address(RVA = "0x1602D64", Offset = "0x1602D64", VA = "0x7BBBE02D64")]
		public void Update()
		{
		}

		// Token: 0x06009DDE RID: 40414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DDE")]
		[Address(RVA = "0x1604A28", Offset = "0x1604A28", VA = "0x7BBBE04A28")]
		private void DetectionPlayers()
		{
		}

		// Token: 0x06009DDF RID: 40415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DDF")]
		[Address(RVA = "0x16046F0", Offset = "0x16046F0", VA = "0x7BBBE046F0")]
		private void DetectionCars()
		{
		}

		// Token: 0x0400A402 RID: 41986
		[Token(Token = "0x400A402")]
		[FieldOffset(Offset = "0x10")]
		private ]XMFBq\u0081 m_Detector;

		// Token: 0x0400A403 RID: 41987
		[Token(Token = "0x400A403")]
		[FieldOffset(Offset = "0x18")]
		private Player m_LocalPlayer;

		// Token: 0x0400A404 RID: 41988
		[Token(Token = "0x400A404")]
		[FieldOffset(Offset = "0x20")]
		private float m_Range;

		// Token: 0x0400A405 RID: 41989
		[Token(Token = "0x400A405")]
		[FieldOffset(Offset = "0x24")]
		private float m_Interval;

		// Token: 0x0400A406 RID: 41990
		[Token(Token = "0x400A406")]
		[FieldOffset(Offset = "0x28")]
		private float m_ShowPointTime;

		// Token: 0x0400A407 RID: 41991
		[Token(Token = "0x400A407")]
		[FieldOffset(Offset = "0x2C")]
		private float m_FadeTime;

		// Token: 0x0400A408 RID: 41992
		[Token(Token = "0x400A408")]
		[FieldOffset(Offset = "0x30")]
		private Player.T[m m_LastState;

		// Token: 0x0400A409 RID: 41993
		[Token(Token = "0x400A409")]
		[FieldOffset(Offset = "0x34")]
		public bool ShowAirLine;

		// Token: 0x0400A40A RID: 41994
		[Token(Token = "0x400A40A")]
		[FieldOffset(Offset = "0x35")]
		public bool ShowCircle;

		// Token: 0x0400A40B RID: 41995
		[Token(Token = "0x400A40B")]
		[FieldOffset(Offset = "0x38")]
		public List<Vector3> DetectedPoints;

		// Token: 0x0400A40C RID: 41996
		[Token(Token = "0x400A40C")]
		[FieldOffset(Offset = "0x40")]
		public List<Vector3> DetectedCarPoints;

		// Token: 0x0400A40D RID: 41997
		[Token(Token = "0x400A40D")]
		[FieldOffset(Offset = "0x48")]
		public int LastDetectFrame;

		// Token: 0x0400A40E RID: 41998
		[Token(Token = "0x400A40E")]
		[FieldOffset(Offset = "0x4C")]
		public float LastDetectTime;

		// Token: 0x0400A40F RID: 41999
		[Token(Token = "0x400A40F")]
		[FieldOffset(Offset = "0x50")]
		public float NextDetectTime;

		// Token: 0x0400A410 RID: 42000
		[Token(Token = "0x400A410")]
		[FieldOffset(Offset = "0x54")]
		public float FadeStartTime;

		// Token: 0x0400A411 RID: 42001
		[Token(Token = "0x400A411")]
		[FieldOffset(Offset = "0x58")]
		public float FadeEndTime;

		// Token: 0x0400A412 RID: 42002
		[Token(Token = "0x400A412")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FB6C", Offset = "0x112FB6C")]
		private bool <Stopped>k__BackingField;

		// Token: 0x0400A413 RID: 42003
		[Token(Token = "0x400A413")]
		[FieldOffset(Offset = "0x60")]
		private int m_RefCount;

		// Token: 0x0400A414 RID: 42004
		[Token(Token = "0x400A414")]
		[FieldOffset(Offset = "0x0")]
		private static DetectorMapObjectModel Instance;
	}
}
