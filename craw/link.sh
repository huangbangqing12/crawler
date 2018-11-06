i=1
cnt=$1
while [ $i -le $cnt ]
do
    python3 ./Linker.py
    let i++
    sleep 1
done