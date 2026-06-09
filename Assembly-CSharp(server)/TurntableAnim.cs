using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000100 RID: 256
[Token(Token = "0x2000100")]
public class TurntableAnim : MonoBehaviour
{
	// Token: 0x060004B0 RID: 1200 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004B0")]
	[Address(RVA = "0x1C96454", Offset = "0x1C96454", VA = "0x7BBC496454")]
	public void DoCircle(List<uint> idList)
	{
	}

	// Token: 0x060004B1 RID: 1201 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004B1")]
	[Address(RVA = "0x1C96480", Offset = "0x1C96480", VA = "0x7BBC496480")]
	private void InitData()
	{
	}

	// Token: 0x060004B2 RID: 1202 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004B2")]
	[Address(RVA = "0x1C96560", Offset = "0x1C96560", VA = "0x7BBC496560")]
	private void GenRewardIndexList()
	{
	}

	// Token: 0x060004B3 RID: 1203 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004B3")]
	[Address(RVA = "0x1C96724", Offset = "0x1C96724", VA = "0x7BBC496724")]
	private void BuildLapRateCurve()
	{
	}

	// Token: 0x060004B4 RID: 1204 RVA: 0x00002CB8 File Offset: 0x00000EB8
	[Token(Token = "0x60004B4")]
	[Address(RVA = "0x1C96834", Offset = "0x1C96834", VA = "0x7BBC496834")]
	private TurntableAnim.CircleStage GetCircleStage(int curIterationCounter)
	{
		return TurntableAnim.CircleStage.NORMAL_RUNNING;
	}

	// Token: 0x060004B5 RID: 1205 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004B5")]
	[Address(RVA = "0x1C96A00", Offset = "0x1C96A00", VA = "0x7BBC496A00")]
	private void Iteration()
	{
	}

	// Token: 0x060004B6 RID: 1206 RVA: 0x00002CD0 File Offset: 0x00000ED0
	[Token(Token = "0x60004B6")]
	[Address(RVA = "0x1C96AEC", Offset = "0x1C96AEC", VA = "0x7BBC496AEC")]
	private float RateSample(int curIterationCounter)
	{
		return 0f;
	}

	// Token: 0x060004B7 RID: 1207 RVA: 0x00002CE8 File Offset: 0x00000EE8
	[Token(Token = "0x60004B7")]
	[Address(RVA = "0x1C96BA8", Offset = "0x1C96BA8", VA = "0x7BBC496BA8")]
	private float RateCelling(float rate)
	{
		return 0f;
	}

	// Token: 0x060004B8 RID: 1208 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004B8")]
	[Address(RVA = "0x1C96BB8", Offset = "0x1C96BB8", VA = "0x7BBC496BB8")]
	private void Update()
	{
	}

	// Token: 0x060004B9 RID: 1209 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004B9")]
	[Address(RVA = "0x1C96E1C", Offset = "0x1C96E1C", VA = "0x7BBC496E1C")]
	[Attribute(Name = "ContextMenu", RVA = "0x1132D5C", Offset = "0x1132D5C")]
	private void Text()
	{
	}

	// Token: 0x060004BA RID: 1210 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004BA")]
	[Address(RVA = "0x1C96F10", Offset = "0x1C96F10", VA = "0x7BBC496F10")]
	public TurntableAnim()
	{
	}

	// Token: 0x04000401 RID: 1025
	[Token(Token = "0x4000401")]
	[FieldOffset(Offset = "0x18")]
	private List<TurntableAnim.RewardIdx> m_RewardIdxList;

	// Token: 0x04000402 RID: 1026
	[Token(Token = "0x4000402")]
	[FieldOffset(Offset = "0x20")]
	private int m_IterationCounter;

	// Token: 0x04000403 RID: 1027
	[Token(Token = "0x4000403")]
	private const int TURNTABLE_REWARD_CNT = 7;

	// Token: 0x04000404 RID: 1028
	[Token(Token = "0x4000404")]
	private const float ROTATE_ANGLE = 51.42857f;

	// Token: 0x04000405 RID: 1029
	[Token(Token = "0x4000405")]
	[FieldOffset(Offset = "0x24")]
	private bool doCircle;

	// Token: 0x04000406 RID: 1030
	[Token(Token = "0x4000406")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 lastRotate;

	// Token: 0x04000407 RID: 1031
	[Token(Token = "0x4000407")]
	[FieldOffset(Offset = "0x34")]
	private float leap;

	// Token: 0x04000408 RID: 1032
	[Token(Token = "0x4000408")]
	[FieldOffset(Offset = "0x38")]
	private bool startBack;

	// Token: 0x04000409 RID: 1033
	[Token(Token = "0x4000409")]
	[FieldOffset(Offset = "0x3C")]
	public int circle_cnt;

	// Token: 0x0400040A RID: 1034
	[Token(Token = "0x400040A")]
	[FieldOffset(Offset = "0x40")]
	public int direction;

	// Token: 0x0400040B RID: 1035
	[Token(Token = "0x400040B")]
	[FieldOffset(Offset = "0x44")]
	public float maxDuration;

	// Token: 0x0400040C RID: 1036
	[Token(Token = "0x400040C")]
	[FieldOffset(Offset = "0x48")]
	public float minDuration;

	// Token: 0x0400040D RID: 1037
	[Token(Token = "0x400040D")]
	[FieldOffset(Offset = "0x4C")]
	public int powers;

	// Token: 0x0400040E RID: 1038
	[Token(Token = "0x400040E")]
	[FieldOffset(Offset = "0x50")]
	public bool needBack;

	// Token: 0x0400040F RID: 1039
	[Token(Token = "0x400040F")]
	[FieldOffset(Offset = "0x54")]
	public float backDuration;

	// Token: 0x04000410 RID: 1040
	[Token(Token = "0x4000410")]
	[FieldOffset(Offset = "0x58")]
	public float backDelay;

	// Token: 0x04000411 RID: 1041
	[Token(Token = "0x4000411")]
	[FieldOffset(Offset = "0x60")]
	private TurntableAnim.RateCurve m_Curve;

	// Token: 0x04000412 RID: 1042
	[Token(Token = "0x4000412")]
	[FieldOffset(Offset = "0x68")]
	private List<uint> m_IDList;

	// Token: 0x02000101 RID: 257
	[Token(Token = "0x2000101")]
	private enum CircleStage
	{
		// Token: 0x04000414 RID: 1044
		[Token(Token = "0x4000414")]
		NORMAL_RUNNING,
		// Token: 0x04000415 RID: 1045
		[Token(Token = "0x4000415")]
		BACK,
		// Token: 0x04000416 RID: 1046
		[Token(Token = "0x4000416")]
		END
	}

	// Token: 0x02000102 RID: 258
	[Token(Token = "0x2000102")]
	private class RewardIdx
	{
		// Token: 0x060004BB RID: 1211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x1C9682C", Offset = "0x1C9682C", VA = "0x7BBC49682C")]
		public RewardIdx()
		{
		}

		// Token: 0x04000417 RID: 1047
		[Token(Token = "0x4000417")]
		[FieldOffset(Offset = "0x10")]
		public int idx;

		// Token: 0x04000418 RID: 1048
		[Token(Token = "0x4000418")]
		[FieldOffset(Offset = "0x14")]
		public int iterationIdx;
	}

	// Token: 0x02000103 RID: 259
	[Token(Token = "0x2000103")]
	private class RateCurve
	{
		// Token: 0x060004BC RID: 1212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x1C97010", Offset = "0x1C97010", VA = "0x7BBC497010")]
		public RateCurve()
		{
		}

		// Token: 0x04000419 RID: 1049
		[Token(Token = "0x4000419")]
		[FieldOffset(Offset = "0x10")]
		public float a;

		// Token: 0x0400041A RID: 1050
		[Token(Token = "0x400041A")]
		[FieldOffset(Offset = "0x14")]
		public int powers;

		// Token: 0x0400041B RID: 1051
		[Token(Token = "0x400041B")]
		[FieldOffset(Offset = "0x18")]
		public float endY;
	}
}
