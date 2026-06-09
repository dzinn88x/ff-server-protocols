using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001BF RID: 447
[Token(Token = "0x20001BF")]
public interface VehicleControllerInterface
{
	// Token: 0x170000A2 RID: 162
	// (get) Token: 0x0600095A RID: 2394
	// (set) Token: 0x06000959 RID: 2393
	[Token(Token = "0x170000A2")]
	bool ModelVisible { [Token(Token = "0x600095A")] get; [Token(Token = "0x6000959")] set; }

	// Token: 0x170000A3 RID: 163
	// (get) Token: 0x0600095B RID: 2395
	[Token(Token = "0x170000A3")]
	float SteerAngle { [Token(Token = "0x600095B")] get; }

	// Token: 0x170000A4 RID: 164
	// (get) Token: 0x0600095C RID: 2396
	[Token(Token = "0x170000A4")]
	float Velocity { [Token(Token = "0x600095C")] get; }

	// Token: 0x170000A5 RID: 165
	// (get) Token: 0x0600095D RID: 2397
	[Token(Token = "0x170000A5")]
	float GasInput { [Token(Token = "0x600095D")] get; }

	// Token: 0x170000A6 RID: 166
	// (get) Token: 0x0600095E RID: 2398
	[Token(Token = "0x170000A6")]
	float BrakeInput { [Token(Token = "0x600095E")] get; }

	// Token: 0x170000A7 RID: 167
	// (get) Token: 0x0600095F RID: 2399
	[Token(Token = "0x170000A7")]
	float SteerInput { [Token(Token = "0x600095F")] get; }

	// Token: 0x170000A8 RID: 168
	// (get) Token: 0x06000960 RID: 2400
	[Token(Token = "0x170000A8")]
	int Direction { [Token(Token = "0x6000960")] get; }

	// Token: 0x170000A9 RID: 169
	// (get) Token: 0x06000961 RID: 2401
	[Token(Token = "0x170000A9")]
	bool IsGrounded { [Token(Token = "0x6000961")] get; }

	// Token: 0x170000AA RID: 170
	// (get) Token: 0x06000962 RID: 2402
	[Token(Token = "0x170000AA")]
	float CurEngineRPM { [Token(Token = "0x6000962")] get; }

	// Token: 0x06000963 RID: 2403
	[Token(Token = "0x6000963")]
	float CaculateVehicleRevs();

	// Token: 0x170000AB RID: 171
	// (get) Token: 0x06000964 RID: 2404
	[Token(Token = "0x170000AB")]
	Transform VehicleCOM { [Token(Token = "0x6000964")] get; }

	// Token: 0x170000AC RID: 172
	// (get) Token: 0x06000965 RID: 2405
	[Token(Token = "0x170000AC")]
	VehicleControllerInfo ControllerInfo { [Token(Token = "0x6000965")] get; }

	// Token: 0x06000966 RID: 2406
	[Token(Token = "0x6000966")]
	void BindVehicleSkin(VehicleSkinInfoBase skin_info);

	// Token: 0x06000967 RID: 2407
	[Token(Token = "0x6000967")]
	void SetControllerInfo(VehicleControllerInfo i);

	// Token: 0x06000968 RID: 2408
	[Token(Token = "0x6000968")]
	void SetVehicleEnable(bool isEnable, bool switchController = false);

	// Token: 0x06000969 RID: 2409
	[Token(Token = "0x6000969")]
	void SetMaxSpeedScale(float scale);

	// Token: 0x0600096A RID: 2410
	[Token(Token = "0x600096A")]
	void SetDriverSpeedScale(float scale);

	// Token: 0x0600096B RID: 2411
	[Token(Token = "0x600096B")]
	float GetDriverSpeedScale();

	// Token: 0x0600096C RID: 2412
	[Token(Token = "0x600096C")]
	void LockMaxSpeed(float speed);

	// Token: 0x0600096D RID: 2413
	[Token(Token = "0x600096D")]
	void UnLockMaxSpeed();

	// Token: 0x0600096E RID: 2414
	[Token(Token = "0x600096E")]
	void UpdateVehicleSpeed(float rpm, float velocity);

	// Token: 0x0600096F RID: 2415
	[Token(Token = "0x600096F")]
	void UpdateVehicleSteerAngle(float steerAngle);

	// Token: 0x06000970 RID: 2416
	[Token(Token = "0x6000970")]
	void VehicleLazyFixedUpdate(float gameTime, float deltaTime);

	// Token: 0x06000971 RID: 2417
	[Token(Token = "0x6000971")]
	void VehicleLasyUpdate(float gameTime, float deltaTime);

	// Token: 0x06000972 RID: 2418
	[Token(Token = "0x6000972")]
	void VehicleUpdateInput(bool gas, bool brake, Vector3 steer);

	// Token: 0x06000973 RID: 2419
	[Token(Token = "0x6000973")]
	void VehicleUpdateInput(float gas, float brake, Vector3 steer);

	// Token: 0x06000974 RID: 2420
	[Token(Token = "0x6000974")]
	void KillEngine();

	// Token: 0x06000975 RID: 2421
	[Token(Token = "0x6000975")]
	void StartEngine();

	// Token: 0x06000976 RID: 2422
	[Token(Token = "0x6000976")]
	int GetWheelType(GameObject go);

	// Token: 0x06000977 RID: 2423
	[Token(Token = "0x6000977")]
	void StartBoost(float torque, float maxSpeed, float angle);

	// Token: 0x06000978 RID: 2424
	[Token(Token = "0x6000978")]
	void StopBoost();

	// Token: 0x06000979 RID: 2425
	[Token(Token = "0x6000979")]
	void SetJumpHeightRate(float rate);

	// Token: 0x0600097A RID: 2426
	[Token(Token = "0x600097A")]
	void SetHightSpeedSteerAngleRate(float rate);

	// Token: 0x0600097B RID: 2427
	[Token(Token = "0x600097B")]
	void SetEngineTorqueRate(float rate);

	// Token: 0x0600097C RID: 2428
	[Token(Token = "0x600097C")]
	void SetBrakeTorqueRate(float rate);

	// Token: 0x0600097D RID: 2429
	[Token(Token = "0x600097D")]
	void ForceStop();
}
