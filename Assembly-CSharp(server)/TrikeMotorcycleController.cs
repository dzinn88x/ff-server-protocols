using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000AD RID: 173
[Token(Token = "0x20000AD")]
public class TrikeMotorcycleController : RMCRealisticMotorcycleController
{
	// Token: 0x17000031 RID: 49
	// (get) Token: 0x06000296 RID: 662 RVA: 0x00002580 File Offset: 0x00000780
	[Token(Token = "0x17000031")]
	public override bool IsGrounded
	{
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x22671C4", Offset = "0x22671C4", VA = "0x7BBCA671C4", Slot = "42")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000032 RID: 50
	// (get) Token: 0x06000297 RID: 663 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000032")]
	public override List<WheelColliderInterface> WheelColliders
	{
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x2267408", Offset = "0x2267408", VA = "0x7BBCA67408", Slot = "41")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000298 RID: 664 RVA: 0x00002598 File Offset: 0x00000798
	[Token(Token = "0x6000298")]
	[Address(RVA = "0x226750C", Offset = "0x226750C", VA = "0x7BBCA6750C", Slot = "53")]
	public override int GetWheelType(GameObject go)
	{
		return 0;
	}

	// Token: 0x06000299 RID: 665 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000299")]
	[Address(RVA = "0x2267668", Offset = "0x2267668", VA = "0x7BBCA67668", Slot = "43")]
	protected override void Start()
	{
	}

	// Token: 0x0600029A RID: 666 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600029A")]
	[Address(RVA = "0x2267920", Offset = "0x2267920", VA = "0x7BBCA67920", Slot = "44")]
	public override void VehicleLazyFixedUpdate(float gameTime, float deltaTime)
	{
	}

	// Token: 0x0600029B RID: 667 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600029B")]
	[Address(RVA = "0x2267D84", Offset = "0x2267D84", VA = "0x7BBCA67D84", Slot = "45")]
	protected override void InputHandle()
	{
	}

	// Token: 0x0600029C RID: 668 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600029C")]
	[Address(RVA = "0x2267DF0", Offset = "0x2267DF0", VA = "0x7BBCA67DF0", Slot = "46")]
	protected override void Engine()
	{
	}

	// Token: 0x0600029D RID: 669 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600029D")]
	[Address(RVA = "0x2267F6C", Offset = "0x2267F6C", VA = "0x7BBCA67F6C", Slot = "47")]
	protected override void ApplyMotorTorque()
	{
	}

	// Token: 0x0600029E RID: 670 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600029E")]
	[Address(RVA = "0x2268250", Offset = "0x2268250", VA = "0x7BBCA68250")]
	private void ApplyMotorTorque(WheelCollider wheel, float torque)
	{
	}

	// Token: 0x0600029F RID: 671 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600029F")]
	[Address(RVA = "0x2268290", Offset = "0x2268290", VA = "0x7BBCA68290", Slot = "48")]
	public override void Braking()
	{
	}

	// Token: 0x060002A0 RID: 672 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x22685A8", Offset = "0x22685A8", VA = "0x7BBCA685A8", Slot = "49")]
	protected override void WheelAlign()
	{
	}

	// Token: 0x060002A1 RID: 673 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x2268604", Offset = "0x2268604", VA = "0x7BBCA68604")]
	private void WheelAlign(WheelCollider wheelCol, Transform wheelColTrans, Transform wheelTrans, ref float rot)
	{
	}

	// Token: 0x060002A2 RID: 674 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x2268C7C", Offset = "0x2268C7C", VA = "0x7BBCA68C7C", Slot = "50")]
	protected override void RotateHandlebarFenders()
	{
	}

	// Token: 0x060002A3 RID: 675 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x2268F08", Offset = "0x2268F08", VA = "0x7BBCA68F08", Slot = "51")]
	protected override void Lean()
	{
	}

	// Token: 0x060002A4 RID: 676 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x2267948", Offset = "0x2267948", VA = "0x7BBCA67948")]
	private void AntiRollBars()
	{
	}

	// Token: 0x060002A5 RID: 677 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x2269024", Offset = "0x2269024", VA = "0x7BBCA69024", Slot = "52")]
	public override void SetVehicleEnable(bool isEnable, bool switchController = false)
	{
	}

	// Token: 0x060002A6 RID: 678 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A6")]
	[Address(RVA = "0x2269090", Offset = "0x2269090", VA = "0x7BBCA69090")]
	public TrikeMotorcycleController()
	{
	}

	// Token: 0x040002A6 RID: 678
	[Token(Token = "0x40002A6")]
	[FieldOffset(Offset = "0x168")]
	public MotorcycleWheelController SideWheelCollider;

	// Token: 0x040002A7 RID: 679
	[Token(Token = "0x40002A7")]
	[FieldOffset(Offset = "0x170")]
	protected float RotationValue3;

	// Token: 0x040002A8 RID: 680
	[Token(Token = "0x40002A8")]
	[FieldOffset(Offset = "0x178")]
	protected Transform SideWheelColliderTrans;

	// Token: 0x040002A9 RID: 681
	[Token(Token = "0x40002A9")]
	[FieldOffset(Offset = "0x180")]
	public float SideWheelLeanThreshold;

	// Token: 0x040002AA RID: 682
	[Token(Token = "0x40002AA")]
	[FieldOffset(Offset = "0x184")]
	private float m_SideWheerTorqueWeight;

	// Token: 0x040002AB RID: 683
	[Token(Token = "0x40002AB")]
	[FieldOffset(Offset = "0x188")]
	private float m_ChassisBaseHeight;

	// Token: 0x040002AC RID: 684
	[Token(Token = "0x40002AC")]
	[FieldOffset(Offset = "0x18C")]
	private float m_RearWheersDistance;

	// Token: 0x040002AD RID: 685
	[Token(Token = "0x40002AD")]
	[FieldOffset(Offset = "0x190")]
	public float LeanPosAdjustFactor;

	// Token: 0x040002AE RID: 686
	[Token(Token = "0x40002AE")]
	[FieldOffset(Offset = "0x194")]
	public float antiRollRearHorizontal;

	// Token: 0x040002AF RID: 687
	[Token(Token = "0x40002AF")]
	[FieldOffset(Offset = "0x198")]
	public bool RotateSteeringHandlerAlongGlobalY;

	// Token: 0x040002B0 RID: 688
	[Token(Token = "0x40002B0")]
	private const float EngineRpmMul = 0.18849556f;
}
